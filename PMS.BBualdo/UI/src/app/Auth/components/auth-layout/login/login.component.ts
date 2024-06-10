import { Component, inject } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { emailValidator } from '../../../../../validators/email.validator';
import { LoginModel } from '../../../../../models/LoginModel';
import { AsyncPipe, NgClass } from '@angular/common';
import { LoadingSpinnerComponent } from '../../../../Shared/loading-spinner/loading-spinner.component';
import { LoadingService } from '../../../../../services/loading.service';
import { AuthService } from '../../../../../services/auth.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [
    RouterLink,
    FormsModule,
    ReactiveFormsModule,
    NgClass,
    AsyncPipe,
    LoadingSpinnerComponent,
  ],
  templateUrl: './login.component.html',
})
export class LoginComponent {
  loginForm: FormGroup = new FormGroup({
    email: new FormControl<string>('', [Validators.required, emailValidator]),
    password: new FormControl('', [Validators.required]),
  });

  private authService = inject(AuthService);
  loadingService = inject(LoadingService);
  private router = inject(Router);

  login() {
    this.loginForm.markAllAsTouched();

    if (this.loginForm.valid) {
      const formValues = this.loginForm.value;
      const model: LoginModel = {
        email: formValues.email,
        password: formValues.password,
      };

      this.authService
        .login(model)
        .subscribe(() => this.router.navigate(['../']));
    }
  }
}
