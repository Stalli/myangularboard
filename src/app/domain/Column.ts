import { Card } from './Card';

export class Column {
  id: number;
  orderNo: number;
  title: string;
  cards: Card[];

  constructor(title: string) {
    this.title = title;
  }
}
