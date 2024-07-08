import { Component, inject, OnInit } from '@angular/core';
import { ProductsService } from '../../../../services/products.service';
import { AsyncPipe, formatDate, NgClass } from '@angular/common';
import { MatIcon } from '@angular/material/icon';
import { ProductsTableComponent } from './products-table/products-table.component';
import { PaginatorComponent } from '../shared/paginator/paginator.component';
import { PaginatedProducts } from '../../../../models/PaginatedProducts';
import { Product } from '../../../../models/Product';
import { Dialog } from '@angular/cdk/dialog';
import { ConfirmDialogComponent } from '../shared/dialogs/confirm-dialog/confirm-dialog.component';
import { ManageProductDialogComponent } from '../shared/dialogs/manage-product-dialog/manage-product-dialog.component';
import { LoadingSpinnerComponent } from '../../../Shared/loading-spinner/loading-spinner.component';
import { LoadingService } from '../../../../services/loading.service';

@Component({
  selector: 'app-products',
  standalone: true,
  imports: [
    AsyncPipe,
    MatIcon,
    ProductsTableComponent,
    PaginatorComponent,
    NgClass,
    LoadingSpinnerComponent,
  ],
  templateUrl: './products.component.html',
})
export class ProductsComponent implements OnInit {
  private productsService = inject(ProductsService);
  private loadingService = inject(LoadingService);
  private dialog = inject(Dialog);

  products$ = this.productsService.products$;
  isLoading$ = this.loadingService.isLoading$;
  currentPage = 1;

  ngOnInit() {
    this.productsService.getProducts().subscribe();
  }

  addProduct() {
    const dialogRef = this.dialog.open(ManageProductDialogComponent, {
      data: { title: 'Add Product' },
    });

    dialogRef.closed.subscribe((result: any) => {
      if (result) {
        this.productsService
          .addProduct(result)
          .subscribe(() => this.refreshProducts(this.currentPage));
      }
    });
  }

  updateProduct(product: Product) {
    const dialogRef = this.dialog.open(ManageProductDialogComponent, {
      data: { title: 'Update Product', product: product },
    });

    dialogRef.closed.subscribe((result: any) => {
      if (result) {
        this.productsService
          .updateProduct(result)
          .subscribe(() => this.refreshProducts(this.currentPage));
      }
    });
  }

  deleteProduct(product: Product) {
    const dialogRef = this.dialog.open(ConfirmDialogComponent, {
      data: { name: product.name },
    });
    dialogRef.closed.subscribe((result) => {
      if (result == true) {
        this.productsService
          .deleteProduct(product.id)
          .subscribe(() => this.refreshProducts(this.currentPage));
      }
    });
  }

  refreshProducts(page: number) {
    this.productsService
      .getProducts(page)
      .subscribe((paginatedProducts: PaginatedProducts) => {
        if (this.currentPage !== 1 && paginatedProducts.products.length === 0) {
          this.currentPage--;
          this.refreshProducts(this.currentPage);
        }
      });
  }

  setCurrentPage(page: number) {
    this.currentPage = page;
  }

  protected readonly formatDate = formatDate;
}
