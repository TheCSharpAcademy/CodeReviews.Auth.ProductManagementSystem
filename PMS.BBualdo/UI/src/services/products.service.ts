import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { ErrorsService } from './errors.service';
import { LoadingService } from './loading.service';
import {
  BehaviorSubject,
  catchError,
  finalize,
  Observable,
  of,
  tap,
} from 'rxjs';
import { url } from '../config/config';
import { PaginatedProducts } from '../models/PaginatedProducts';
import { ProductReq } from '../models/ProductReq';

@Injectable({
  providedIn: 'root',
})
export class ProductsService {
  private productsSubject: BehaviorSubject<
    PaginatedProducts | null | undefined
  > = new BehaviorSubject<PaginatedProducts | null | undefined>(undefined);
  products$ = this.productsSubject.asObservable();

  constructor(
    private http: HttpClient,
    private errorsService: ErrorsService,
    private loadingService: LoadingService,
  ) {}

  getProducts(
    page: number = 1,
    pageSize: number = 5,
  ): Observable<PaginatedProducts> {
    this.loadingService.startLoading();
    return this.http
      .get<PaginatedProducts>(
        url + `Products/?page=${page}&pageSize=${pageSize}`,
      )
      .pipe(
        tap((products) => this.productsSubject.next(products)),
        catchError((error) => of(this.handleErrors(error))),
        finalize(() => this.loadingService.stopLoading()),
      );
  }

  addProduct(product: ProductReq) {
    this.loadingService.startLoading();
    return this.http.post(url + 'Products', product).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  updateProduct(product: ProductReq) {
    this.loadingService.startLoading();
    return this.http.put(url + 'Products', product).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  deleteProduct(id: number) {
    this.loadingService.startLoading();
    return this.http.delete(url + 'Products/' + id).pipe(
      catchError((error) => of(this.handleErrors(error))),
      finalize(() => this.loadingService.stopLoading()),
    );
  }

  private handleErrors(error: HttpErrorResponse): any {
    switch (error.status) {
    }

    console.log(error);
  }
}
