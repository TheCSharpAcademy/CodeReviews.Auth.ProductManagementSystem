import { Component, Input } from '@angular/core';
import { AsyncPipe, formatDate } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { PaginatedProducts } from '../../../../../models/PaginatedProducts';
import { Product } from '../../../../../models/Product';

@Component({
  selector: 'products-table',
  standalone: true,
  imports: [AsyncPipe, MatIcon],
  templateUrl: './products-table.component.html',
})
export class ProductsTableComponent {
  @Input() paginatedProducts: PaginatedProducts | null = null;
  @Input() updateProduct: (product: Product) => void = () => {};
  @Input() deleteProduct: (product: Product) => void = () => {};
  protected readonly formatDate = formatDate;
}
