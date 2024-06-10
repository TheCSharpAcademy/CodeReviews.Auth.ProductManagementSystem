import { Component, inject, OnInit } from '@angular/core';
import { AsyncPipe, NgClass } from '@angular/common';
import { LoadingSpinnerComponent } from '../../../Shared/loading-spinner/loading-spinner.component';
import { PaginatorComponent } from '../shared/paginator/paginator.component';
import { ProductsTableComponent } from '../products/products-table/products-table.component';
import { UsersTableComponent } from './users-table/users-table.component';
import { LoadingService } from '../../../../services/loading.service';
import { UsersService } from '../../../../services/users.service';
import { Dialog } from '@angular/cdk/dialog';
import { ConfirmDialogComponent } from '../shared/dialogs/confirm-dialog/confirm-dialog.component';
import { ManageUserDialogComponent } from '../shared/dialogs/manage-user-dialog/manage-user-dialog.component';
import { UserInfo } from '../../../../models/UserInfo';
import { PaginatedUsers } from '../../../../models/PaginatedUsers';
import { AuthService } from '../../../../services/auth.service';

@Component({
  selector: 'app-users',
  standalone: true,
  imports: [
    AsyncPipe,
    LoadingSpinnerComponent,
    PaginatorComponent,
    ProductsTableComponent,
    UsersTableComponent,
    NgClass,
  ],
  templateUrl: './users.component.html',
})
export class UsersComponent implements OnInit {
  private authService = inject(AuthService);
  private usersService = inject(UsersService);
  private loadingService = inject(LoadingService);
  private dialog = inject(Dialog);

  currentUser$ = this.authService.currentUser$;
  users$ = this.usersService.users$;
  isLoading$ = this.loadingService.isLoading$;
  currentPage = 1;

  ngOnInit() {
    this.currentUser$.subscribe((currentUser) => {
      if (currentUser!.roles.includes('Admin')) {
        this.usersService.getUsers().subscribe();
      }
    });
  }

  addUser() {
    const dialogRef = this.dialog.open(ManageUserDialogComponent, {
      data: { title: 'Add User' },
    });

    dialogRef.closed.subscribe((result: any) => {
      if (result) {
        this.usersService
          .addUser(result)
          .subscribe(() => this.refreshUsers(this.currentPage));
      }
    });
  }

  updateUser(user: UserInfo) {
    const dialogRef = this.dialog.open(ManageUserDialogComponent, {
      data: { title: 'Update User', user: user },
    });

    dialogRef.closed.subscribe((result: any) => {
      if (result) {
        this.usersService
          .updateUser(result)
          .subscribe(() => this.refreshUsers(this.currentPage));
      }
    });
  }

  deleteUser(user: UserInfo) {
    const dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: { name: user.email },
    });
    dialogRef.closed.subscribe((result) => {
      if (result == true) {
        this.usersService
          .deleteUser(user.id)
          .subscribe(() => this.refreshUsers(this.currentPage));
      }
    });
  }

  refreshUsers(page: number) {
    this.usersService
      .getUsers(page)
      .subscribe((paginatedUsers: PaginatedUsers) => {
        if (this.currentPage !== 1 && paginatedUsers.users.length === 0) {
          this.currentPage--;
          this.refreshUsers(this.currentPage);
        }
      });
  }

  setCurrentPage(page: number) {
    this.currentPage = page;
  }
}
