import { Component, inject } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { MatIcon } from '@angular/material/icon';
import { DIALOG_DATA, DialogRef } from '@angular/cdk/dialog';
import { emailValidator } from '../../../../../../validators/email.validator';
import { UserReq } from '../../../../../../models/UserReq';
import { NgClass } from '@angular/common';

@Component({
  selector: 'app-manage-user-dialog',
  standalone: true,
  imports: [FormsModule, MatIcon, ReactiveFormsModule, NgClass],
  templateUrl: './manage-user-dialog.component.html',
})
export class ManageUserDialogComponent {
  public data = inject(DIALOG_DATA);
  private dialogRef = inject(DialogRef);

  title = this.data.title;

  userForm = new FormGroup({
    firstName: new FormControl<string>(this.data.user?.firstName || '', [
      Validators.required,
      Validators.minLength(2),
      Validators.maxLength(50),
    ]),
    lastName: new FormControl<string>(this.data.user?.lastName || '', [
      Validators.required,
      Validators.minLength(2),
      Validators.maxLength(50),
    ]),
    email: new FormControl<string>(this.data.user?.email || '', [
      Validators.required,
      emailValidator,
    ]),
  });

  close() {
    this.dialogRef.close();
  }

  generateUser() {
    this.userForm.markAllAsTouched();
    if (this.userForm.valid) {
      const formValues = this.userForm.value;
      const user: UserReq = {
        firstName: formValues.firstName!,
        lastName: formValues.lastName!,
        email: formValues.email!,
      };
      if (this.data.user) {
        user.id = this.data.user.id;
      }

      this.dialogRef.close(user);
    }
  }
}
