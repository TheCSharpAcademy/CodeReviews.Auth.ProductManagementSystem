import { CanActivateFn, Router } from '@angular/router';
import { inject } from '@angular/core';

export const resetPasswordGuard: CanActivateFn = (route) => {
  const token: string | undefined = route.queryParams['token'];
  const email: string | undefined = route.queryParams['email'];

  const router = inject(Router);

  if (token && email) return true;

  router.navigate(['login']);
  return false;
};
