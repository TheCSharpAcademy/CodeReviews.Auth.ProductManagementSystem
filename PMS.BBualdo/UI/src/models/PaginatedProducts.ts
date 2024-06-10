import { Product } from './Product';

export interface PaginatedProducts {
  total: number;
  products: Product[];
}
