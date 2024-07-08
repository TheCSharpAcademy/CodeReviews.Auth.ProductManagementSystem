import { Component, Input } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'back-button',
  standalone: true,
  imports: [MatIcon, RouterLink],
  templateUrl: './back-button.component.html',
})
export class BackButtonComponent {
  @Input() class = '';
}
