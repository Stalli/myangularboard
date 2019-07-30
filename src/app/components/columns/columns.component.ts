import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { CdkDragDrop, moveItemInArray, transferArrayItem } from '@angular/cdk/drag-drop';

import { Column } from '../../domain/Column';
import { Card } from '../../domain/Card';
import { DomainService } from "../../services/domain.service";
import { CardComponent } from '../card/card.component';

@Component({
  selector: 'columns',
  templateUrl: './columns.component.html',
  styleUrls: ['./columns.component.css']
})
export class ColumnsComponent implements OnInit {
  columns: Column[];
  columnWithNewCardAreaOpened: number = null;
  addAnotherListActive: boolean = false;

  constructor(private domainService: DomainService, private modalService: NgbModal) { }

  ngOnInit() {
    this.getColumns();
  }

  getColumns(): void {
    this.domainService.getColumns()
      .subscribe(columns => {
        this.columns = columns.sort((a,b) => a.orderNo - b.orderNo )
      });
  }

  open(cardId:number, columnId:number) {
    const modalRef = this.modalService.open(CardComponent, { size: 'lg' });
    modalRef.componentInstance.id = cardId;
    modalRef.componentInstance.onDeleted.subscribe(
      (_: any) => {
        const currentColumn = this.columns.find(col => col.id == columnId);
        currentColumn.cards = currentColumn.cards.filter(c => c.id != cardId)
      }      
    );
  }

  addCard(columnId: number, text: string) {
    if (!text) { return; }
    const newCard = new Card(columnId, text);
    this.domainService.addEntity(newCard)
      .subscribe(card => {
        this.columns.filter(c => c.id == columnId)[0].cards.push(card);
      });
  }

  addColumn(title: string) {
    if (!title) { return; }
    const column = new Column(title);
    this.domainService.addEntity(column)
      .subscribe(column => {
        this.columns.push(column);
      });
  }

  moveCard(cardId: number, targetColumnId: number) {
    this.domainService.moveCard(cardId, targetColumnId).subscribe();
  }

  moveColumn(previousIndex: number, currentIndex: number){
    this.domainService.moveColumn(previousIndex, currentIndex).subscribe();
  }

  drop(event: CdkDragDrop<string[]>, targetColumnId: number) {
    if (event.previousContainer === event.container) {
      moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);
    } else {
      this.moveCard(event.item.data, targetColumnId);
      transferArrayItem((event.previousContainer.data) as any,
        event.container.data,
        event.previousIndex,
        event.currentIndex);
    }      
  }

  dropColumn(event: CdkDragDrop<string[]>) {
    this.moveColumn(event.previousIndex, event.currentIndex);
    moveItemInArray(event.container.data, event.previousIndex, event.currentIndex);   
  }

  getConnectedList() {
    return this.columns.map(x => `${x.id}`);
  }
}
