import { Component, inject, OnInit } from '@angular/core';
import { AsyncPipe, NgClass } from '@angular/common';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { LoadingSpinnerComponent } from '../../../../Shared/loading-spinner/loading-spinner.component';
import { ActivatedRoute, RouterLink } from '@angular/router';
import { passwordValidator } from '../../../../../validators/password.validator';
import { matchPasswordValidator } from '../../../../../validators/match-password.validator';
import { LoadingService } from '../../../../../services/loading.service';
import { AuthService } from '../../../../../services/auth.service';
import { PasswordResetModel } from '../../../../../models/PasswordResetModel';
import { NewPasswordSuccessComponent } from './new-password-success/new-password-success.component';

@Component({
  selector: 'app-new-password-form',
  standalone: true,
  imports: [
    AsyncPipe,
    FormsModule,
    LoadingSpinnerComponent,
    ReactiveFormsModule,
    RouterLink,
    NgClass,
    NewPasswordSuccessComponent,
  ],
  templateUrl: './new-password-form.component.html',
})
export class NewPasswordFormComponent implements OnInit {
  token: string | undefined;
  email: string | undefined;
  changingPasswordSuccess = false;

  passwordForm: FormGroup = new FormGroup(
    {
      password: new FormControl<string>('', [
        Validators.required,
        passwordValidator,
      ]),
      confirmPassword: new FormControl<string>('', [Validators.required]),
    },
    [matchPasswordValidator],
  );

  loadingService = inject(LoadingService);
  private authService = inject(AuthService);
  private route = inject(ActivatedRoute);

  ngOnInit() {
    this.route.queryParams.subscribe((params) => {
      this.token = params['token'];
      this.email = params['email'];
    });
  }

  resetPassword() {
    this.passwordForm.markAllAsTouched();

    if (this.passwordForm.valid) {
      const formValues = this.passwordForm.value;

      if (this.token && this.email) {
        const model: PasswordResetModel = {
          email: this.email,
          newPassword: formValues.password,
        };

        this.authService.resetPassword(this.token, model).subscribe((value) => {
          if (value) {
            this.changingPasswordSuccess = true;
          }
        });
      }
    }
  }
}
