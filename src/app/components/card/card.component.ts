import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { MatSnackBar } from '@angular/material/snack-bar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { Card } from '../../domain/Card';
import { MyComment } from '../../domain/MyComment';
import { DomainService } from "../../services/domain.service";
import { DescriptionAreaStatus } from './DescriptionAreaStatus';
import { EnumsService } from 'src/app/services/enums.service';

@Component({
  selector: 'card',
  templateUrl: './card.component.html',
  styleUrls: ['./card.component.less']
})
export class CardComponent implements OnInit {
  id:number;
  card:Card;
  descriptionAreaStatus:DescriptionAreaStatus;
  deleteConfirmationIsShown:boolean = false;

  constructor(
    public activeModal: NgbActiveModal,
    private modalService: NgbModal,
    private route: ActivatedRoute, 
    private location: Location,
    private domainService: DomainService,
    private enums: EnumsService, 
    private snackBar: MatSnackBar) {
    console.log("card.component.constructor");
  }

  ngOnInit() {
    this.getCard();
  }
    
  getCard(): void {
    //const id = +this.route.snapshot.paramMap.get('id');
    this.domainService.getCard(this.id)
      .subscribe(card => {
        this.card = card;
        this.setDescriptionAreaStatus();
      });
  }

  setDescriptionAreaStatus(): void {
    this.descriptionAreaStatus = this.card.description ? DescriptionAreaStatus.HasDescription : DescriptionAreaStatus.NoDescription;
  }

  saveComment(commentText: string): void {
    if (!commentText) { return; }
    this.domainService.addEntity(new MyComment(this.card.id, commentText))
      .subscribe(comment => {
        (this.card.comments = this.card.comments || []).push(comment);
      });
  }

  addDescription(description: string): void {
    let previousDescription = this.card.description;
    this.card.description = description;
    this.domainService.changeEntity(this.card).subscribe(
      result => {
        this.card.description=description;
        this.setDescriptionAreaStatus();
      },
      error => {
        this.card.description = previousDescription;
        this.showError();
      }
    );
  }
  showError() {
    this.snackBar.open('An error occured on saving. Please try again', null, { duration: 3000});
  }
}