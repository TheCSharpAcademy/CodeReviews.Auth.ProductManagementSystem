import { Component, inject, Input } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { TitleComponent } from '../../../../Shared/title/title.component';
import { User } from '../../../../../models/User';
import { AuthService } from '../../../../../services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'navbar',
  standalone: true,
  imports: [AsyncPipe, MatIcon, TitleComponent],
  templateUrl: './navbar.component.html',
})
export class NavbarComponent {
  @Input() currentUser: User | undefined | null = undefined;

  private authService = inject(AuthService);
  private router = inject(Router);

  logout() {
    this.authService.logout().subscribe(() => this.router.navigate(['/login']));
  }
}
