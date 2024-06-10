import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'paginator',
  standalone: true,
  imports: [],
  templateUrl: './paginator.component.html',
})
export class PaginatorComponent {
  @Input() totalPages: number | null = null;
  @Input() currentPage = 1;
  @Output() onPageChange = new EventEmitter<number>();

  next() {
    if (this.currentPage !== this.totalPages) {
      this.currentPage++;
      this.onPageChange.emit(this.currentPage);
    }
  }

  prev() {
    if (this.currentPage !== 1) {
      this.currentPage--;
      this.onPageChange.emit(this.currentPage);
    }
  }
}
