import { Injectable } from '@angular/core';
import { InMemoryDbService } from 'angular-in-memory-web-api';

import { Card } from '../domain/Card';
import { MyComment } from '../domain/MyComment';

@Injectable({
  providedIn: 'root'
})
export class InMemoryDataService implements InMemoryDbService {
  createDb() {
    const cards1 = [
      {
        id: 1,
        title: "TestCard1",
        column: "TestColumn",
        columnId: 1,
        description: "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        comments: ["Awful card!", "That's brilliant", "Never again"]
      },
      {
        id: 2,
        title: "TestCard2",
        column: "TestColumn",
        columnId: 1,
        description: "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        //comments: ["Awful card!", "That's brilliant", "Never again"]
      },
      {
        id: 3,
        title: "TestqwdqwdqwdCard3",
        column: "TestColumn",
        columnId: 1,
        description: "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        //comments: ["Awful card!", "That's brilliant", "Never again"]
      }
    ];

    const cards2 = [
      {
        id: 4,
        title: "TestCard4",
        column: "TestColumn",
        columnId: 2,
        description: "TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        //comments: ["Awful card!", "That's brilliant", "Never again"]
      },
      {
        id: 5,
        title: "TestCard5",
        column: "TestColumn",
        columnId: 2,
        description: "2TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        //comments: ["Awful card!", "That's brilliant", "Never again"]
      },
      {
        id: 6,
        title: "Qwasasdasdasdasdasdas6",
        column: "TestColumn",
        columnId: 2,
        description: "3TestLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongLongDescription",
        //comments: ["Awful card!", "That's brilliant", "Never again"]
      }
    ];

    const comments_in_memory = [
      {
        id: 1,
        cardId: 1,
        text: "Comment from database"
      }];

    const columns_in_memory = [
      {
        id: 1,
        title: "ColumnTitleForColumnOne",
        cards: cards1
      },
      {
        id: 2,
        title: "ColumnTitleForColumnTwo",
        cards: cards2
      },
      {
        id: 3,
        title: "ColumnThree",
        cards: cards1
      }
    ];

    const boards_in_memory = [
      {
        id: 1,
        userId: 1,
        columns: columns_in_memory
      }
    ];

    const cards_in_memory = cards1.concat(cards2);

    return { cards_in_memory, comments_in_memory, columns_in_memory, boards_in_memory };
  }

  //genId<T extends Card | Comment>(myTable: T[]): number {
  //  console.log("genId");
  //  return myTable.length > 0 ? Math.max(...myTable.map(t => t.id)) + 1 : 11;
  //}
}
