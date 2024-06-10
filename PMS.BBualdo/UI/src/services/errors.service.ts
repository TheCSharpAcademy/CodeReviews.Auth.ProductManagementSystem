import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ErrorsService {
  private isErrorSubject: BehaviorSubject<boolean> =
    new BehaviorSubject<boolean>(false);
  isError$: Observable<boolean> = this.isErrorSubject.asObservable();
  errors: string[] = [];

  add(errorMessage: string) {
    this.isErrorSubject.next(true);
    this.errors.push(errorMessage);
  }

  clear() {
    this.errors = [];
    this.isErrorSubject.next(false);
  }
}
