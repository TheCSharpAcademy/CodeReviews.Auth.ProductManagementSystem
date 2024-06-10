import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class LoadingService {
  private isLoadingSubject: BehaviorSubject<boolean> =
    new BehaviorSubject<boolean>(false);
  isLoading$: Observable<boolean> = this.isLoadingSubject.asObservable();

  constructor() {}

  startLoading() {
    this.isLoadingSubject.next(true);
  }

  stopLoading() {
    this.isLoadingSubject.next(false);
  }
}
