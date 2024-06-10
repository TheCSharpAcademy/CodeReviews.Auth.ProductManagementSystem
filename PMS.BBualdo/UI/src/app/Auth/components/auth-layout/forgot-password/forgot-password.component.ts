import { Component, inject } from '@angular/core';
import { BackButtonComponent } from '../../../../Shared/back-button/back-button.component';
import {
  FormControl,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { emailValidator } from '../../../../../validators/email.validator';
import { AsyncPipe, NgClass } from '@angular/common';
import { LoadingService } from '../../../../../services/loading.service';
import { LoadingSpinnerComponent } from '../../../../Shared/loading-spinner/loading-spinner.component';
import { ForgotPasswordSuccessComponent } from './forgot-password-success/forgot-password-success.component';
import { AuthService } from '../../../../../services/auth.service';
import { PasswordForgotReq } from '../../../../../models/PasswordForgotReq';

@Component({
  selector: 'app-forgot-password',
  standalone: true,
  imports: [
    BackButtonComponent,
    FormsModule,
    ReactiveFormsModule,
    NgClass,
    AsyncPipe,
    LoadingSpinnerComponent,
    ForgotPasswordSuccessComponent,
  ],
  templateUrl: './forgot-password.component.html',
})
export class ForgotPasswordComponent {
  isSendingSuccess = false;
  emailInput = new FormControl('', [Validators.required, emailValidator]);

  loadingService = inject(LoadingService);
  authService = inject(AuthService);

  resetPassword() {
    this.emailInput.markAsTouched();
    if (this.emailInput.valid) {
      const request: PasswordForgotReq = {
        email: this.emailInput.value!,
      };
      this.authService.passwordRecovery(request).subscribe((value) => {
        if (value) this.isSendingSuccess = true;
      });
    }
  }
}
