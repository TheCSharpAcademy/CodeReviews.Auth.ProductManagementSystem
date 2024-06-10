import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ErrorsService } from './errors.service';
import { LoadingService } from './loading.service';
import {
  BehaviorSubject,
  catchError,
  finalize,
  Observable,
  of,
  tap,
} from 'rxjs';
import { PaginatedUsers } from '../models/PaginatedUsers';
import { url } from '../config/config';
import { UserReq } from '../models/UserReq';
import { Dialog } from '@angular/cdk/dialog';
import { ErrorDialogComponent } from '../app/Shared/error-dialog/error-dialog.component';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root',
})
export class UsersService {
  private usersSubject = new BehaviorSubject<PaginatedUsers | undefined | null>(
    undefined,
  );
  users$ = this.usersSubject.asObservable();

  constructor(
    private http: HttpClient,
    private errorsService: ErrorsService,
    private loadingService: LoadingService,
    private dialog: Dialog,
    private router: Router,
  ) {}

  getUsers(page: number = 1, pageSize: number = 5): Observable<PaginatedUsers> {
    this.loadingService.startLoading();
    return this.http
      .get<PaginatedUsers>(url + `Users/?page=${page}&pageSize=${pageSize}`)
      .pipe(
        tap((users) => this.usersSubject.next(users)),
        catchError((error) => of(this.handleErrors(error))),
        finalize(() => this.loadingService.stopLoading()),
      );
  }

  addUser(user: UserReq) {
    this.loadingService.startLoading();
    return this.http.post(url + 'Users', user).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  updateUser(user: UserReq) {
    this.loadingService.startLoading();
    return this.http.put(url + 'Users', user).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  deleteUser(id: string) {
    this.loadingService.startLoading();
    return this.http.delete(url + `Users/?id=${id}`).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  private handleErrors(error: HttpErrorResponse): any {
    switch (error.status) {
      case 400: {
        if (error.error) {
          error.error.forEach((err: { code: string; description: string }) =>
            this.errorsService.add(err.description),
          );
        }
        break;
      }
    }

    this.dialog.open(ErrorDialogComponent);

    console.log(error);
  }
}
