import { Component, inject } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { AuthService } from '../../../../services/auth.service';

@Component({
  selector: 'app-dashboard',
  standalone: true,
  imports: [AsyncPipe],
  templateUrl: './dashboard.component.html',
})
export class DashboardComponent {
  private authService = inject(AuthService);
  currentUser$ = this.authService.currentUser$;
}
