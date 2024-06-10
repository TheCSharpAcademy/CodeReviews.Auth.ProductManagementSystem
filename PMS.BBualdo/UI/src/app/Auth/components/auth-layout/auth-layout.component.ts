import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TitleComponent } from '../../../Shared/title/title.component';

@Component({
  selector: 'app-auth-layout',
  standalone: true,
  imports: [RouterOutlet, TitleComponent],
  templateUrl: './auth-layout.component.html',
})
export class AuthLayoutComponent {}
