import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export const passwordValidator: ValidatorFn = (
  control: AbstractControl,
): null | ValidationErrors => {
  const hasUppercase: boolean = /[A-Z]/.test(control.value);
  const hasLowercase: boolean = /[a-z]/.test(control.value);
  const hasDigit: boolean = /[0-9]/.test(control.value);
  const hasSpecialChar: boolean = /[~`!@#$%^&*()_\-=+,./?;:'"\\|\[\]{}<>]/.test(
    control.value,
  );

  if (
    control.value &&
    (!hasUppercase || !hasLowercase || !hasDigit || !hasSpecialChar)
  )
    return { invalidPassword: true };

  return null;
};
