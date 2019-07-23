import { Column } from './Column';
import { MyComment } from './MyComment';
import { BaseEntity } from './BaseEntity';

export class Card implements BaseEntity {
  id: number;
  title: string;
  //column: Column;
  columnTitle: string;
  columnId?: number;
  description: string;
  comments: MyComment[];

  constructor(columnId: number, title: string) {
    // this.id = cardId;
    this.columnId = columnId;
    this.title = title;
  }

  static fromJSON(json): Card {
    const output = new Card(json['columnId'],json['title']);
    output.id = json['id'];
    output.columnTitle = json['columnTitle'];
    output.comments = Object.keys(json['comments']).map(i => MyComment.fromJSON(json['comments'][i]));
    output.description = json['description'];

    return output;
  }
}
