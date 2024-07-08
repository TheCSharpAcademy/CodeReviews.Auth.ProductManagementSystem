import { Component, inject, OnInit } from '@angular/core';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { AuthService } from '../../../../../services/auth.service';

@Component({
  selector: 'app-email-confirmation',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './email-confirmation.component.html',
})
export class EmailConfirmationComponent implements OnInit {
  userId: string | undefined;
  token: string | undefined;
  isConfirmed = false;

  private authService = inject(AuthService);
  private route = inject(ActivatedRoute);

  ngOnInit() {
    this.route.queryParams.subscribe((params) => {
      this.userId = params['userId'];
      this.token = params['token'];
    });

    if (this.userId && this.token) {
      this.authService
        .confirmEmail(this.userId, this.token)
        .subscribe((result) => {
          if (result) this.isConfirmed = true;
        });
    }
  }
}
