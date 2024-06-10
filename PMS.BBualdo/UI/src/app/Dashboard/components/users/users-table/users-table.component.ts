import { Component, Input } from '@angular/core';
import { MatIcon } from '@angular/material/icon';
import { PaginatedUsers } from '../../../../../models/PaginatedUsers';
import { UserInfo } from '../../../../../models/UserInfo';

@Component({
  selector: 'users-table',
  standalone: true,
  imports: [MatIcon],
  templateUrl: './users-table.component.html',
})
export class UsersTableComponent {
  @Input() paginatedUsers: PaginatedUsers | null = null;
  @Input() updateUser: (user: UserInfo) => void = () => {};
  @Input() deleteUser: (user: UserInfo) => void = () => {};
}
