import { BaseEntity } from './BaseEntity';

export class MyComment implements BaseEntity {
  className: string;
  id: number;
  cardId: number;
  text: string;

  constructor(cardId: number, message: string) {
    
    this.cardId = cardId;
    this.text = message;
    this.className = "MyComment";
  }

  static fromJSON(json): MyComment {
    const output = new MyComment(json['cardId'], json['text']);
    output.id = json['id'];

    return output;
  }
}
