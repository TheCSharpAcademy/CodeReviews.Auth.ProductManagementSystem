import { UserInfo } from './UserInfo';

export interface PaginatedUsers {
  total: number;
  users: UserInfo[];
}
