import { AbstractControl, ValidationErrors, ValidatorFn } from '@angular/forms';

export const emailValidator: ValidatorFn = (
  control: AbstractControl<string>,
): null | ValidationErrors => {
  const regex: RegExp = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$/;

  if (control.value && !regex.test(control.value))
    return { invalidEmail: true };

  return null;
};
