import { Card } from './Card';

export class Column {
  id: number;
  orderNo: number;
  title: string;
  userId: string;
  cards: Card[];

  constructor(title: string, userId: string) {
    this.title = title;
    this.userId = userId;
  }
}
