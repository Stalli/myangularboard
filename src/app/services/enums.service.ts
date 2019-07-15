import { Injectable } from '@angular/core';
import { DescriptionAreaStatus } from '../components/card/DescriptionAreaStatus';

@Injectable({providedIn: 'root'})
export class EnumsService {
    DescriptionAreaStatus = DescriptionAreaStatus;
}