import { Card } from './Card';
import { BaseEntity } from './BaseEntity';

export class Column implements BaseEntity {
  className: string;
  id: number;
  orderNo: number;
  title: string;
  userId: string;
  cards: Card[];

  constructor(title: string, userId: string) {
    this.title = title;
    this.userId = userId;
    this.className = "Column";
  }
}
