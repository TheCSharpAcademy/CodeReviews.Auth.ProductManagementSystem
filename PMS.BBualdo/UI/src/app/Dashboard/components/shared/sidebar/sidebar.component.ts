import { Component, inject } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { Router } from '@angular/router';
import { NgClass } from '@angular/common';

@Component({
  selector: 'sidebar',
  standalone: true,
  imports: [MatIcon, NgClass],
  templateUrl: './sidebar.component.html',
})
export class SidebarComponent {
  router = inject(Router);
  sidebarLinks = [
    { title: 'Dashboard', slug: '/', icon: 'home' },
    { title: 'Products', slug: '/products', icon: 'warehouse' },
    { title: 'Users', slug: '/users', icon: 'supervisor_account' },
  ];
  currentUrl = this.router.url;
}
