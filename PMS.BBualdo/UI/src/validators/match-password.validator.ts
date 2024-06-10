import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export const matchPasswordValidator: ValidatorFn = (
  control: AbstractControl,
): null | ValidationErrors => {
  const password = control.get<string>('password')?.value;
  const confirmPassword = control.get<string>('confirmPassword')?.value;

  if (password && confirmPassword && password !== confirmPassword)
    return { passwordMatchError: true };

  return null;
};
