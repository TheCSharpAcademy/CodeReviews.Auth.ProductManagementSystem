export interface ProductReq {
  id?: number;
  name: string;
  price: number;
  isActive: boolean;
  dateAdded: Date | string;
}
