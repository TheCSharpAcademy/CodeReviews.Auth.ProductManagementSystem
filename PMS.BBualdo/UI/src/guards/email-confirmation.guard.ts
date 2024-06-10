import { CanActivateFn, Router } from '@angular/router';
import { inject } from '@angular/core';

export const emailConfirmationGuard: CanActivateFn = (route) => {
  const userId: string | undefined = route.queryParams['userId'];
  const token: string | undefined = route.queryParams['token'];

  const router = inject(Router);

  if (userId && token) return true;

  router.navigate(['login']);
  return false;
};
