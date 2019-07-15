import { Component, OnInit } from '@angular/core';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';

import { CardComponent } from '../card/card.component';

@Component({
  selector: 'ngbd-modal-component',
  templateUrl: './modal.component.html'
})
export class ModalComponent {
  constructor(private modalService: NgbModal) { }

  open() {
    const modalRef = this.modalService.open(CardComponent);
    modalRef.componentInstance.name = 'World';
  }
}
