import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Card } from '../domain/Card';
import { Column } from '../domain/Column';
import { MyComment } from '../domain/MyComment';
import { BaseEntity } from '../domain/BaseEntity';
import { environment } from '../../environments/environment';
//import { CARDS } from '../domain/mock-domain';
//import { COLUMNS } from '../domain/mock-domain';

const httpOptions = {
  headers: new HttpHeaders({ 
    'Content-Type': 'application/json',
    'Access-Control-Allow-Methods': 'POST, PUT, GET, OPTIONS'})
};

@Injectable({
  providedIn: 'root'
})
export class DomainService {
  private activeUrl = environment.apiUrl;
  private commentsUrl = `${this.activeUrl}/api/comments`;
  private columnsUrl = `${this.activeUrl}/api/columns`;
  private cardsUrl = `${this.activeUrl}/api/cards`
  private cardsMovingUrl = `${this.activeUrl}/api/cards/move`;
  private columnsMovingUrl = `${this.activeUrl}/api/columns/move`;

  constructor(private http: HttpClient) { }

  addEntity<T>(entity: T): Observable<T> {
    return this.http.post<T>(this.getUrl(entity), entity, httpOptions).pipe(
      tap(result => {
        const outcome = result ? `succeed` : `failed`;
        console.log("addEntity "+ outcome)
      }),
      catchError(this.handleError<T>('addEntity'))
    );
  }

  changeEntity<T extends BaseEntity>(entity: T): Observable<T> {
    return this.http.put<T>(`${this.getUrl(entity)}/${entity.id}`, entity, httpOptions);
  }

  deleteEntity<T extends BaseEntity>(entity: T): Observable<T> {
    return this.http.delete<T>(`${this.getUrl(entity)}/${entity.id}`, httpOptions);
  }

  getUrl<T>(entity: T): string {
    const type = entity.constructor.name;
    switch (type) {
      case "Column":
        return this.columnsUrl;
      case "Card":
        return this.cardsUrl;
      case "MyComment":
        return this.commentsUrl;
      default:
        console.log("no url for the type "+ type)
    }
  }

  getCards(): Observable<Card[]> {
    //return of(CARDS);
    return this.http.get<Card[]>(this.cardsUrl);
  }

  getCard(id: number): Observable<Card> {
    const url = `${this.cardsUrl}/${id}`;
    return this.http.get<Card>(url)
       .pipe(
          map(response => Card.fromJSON(response))
       );
  }

  getColumns(): Observable<Column[]> {
    //return of(COLUMNS);
    return this.http.get<Column[]>(this.columnsUrl);
  }

  getColumn(id: number): Observable<Column> {
    const url = `${this.columnsUrl}/${id}`;
    return this.http.get<Column>(url);
    //return of(COLUMNS.find(column => column.id === id));
  }

  moveCard(cardId: number, targetColumnId: number): Observable<boolean> {
    return this.http.post<boolean>(this.cardsMovingUrl, JSON.stringify({cardId, targetColumnId}), httpOptions).pipe(
        tap(_ => console.log("moving card " + cardId + " to column " + targetColumnId + " succeed.")),
        catchError(this.handleError<boolean>('moveCard'))
    );
  }

  moveColumn(previousColumnOrderNo: number, newColumnOrderNo: number): Observable<boolean> {
    //change 0-based to 1-based
    newColumnOrderNo++;
    previousColumnOrderNo++;

    return this.http.post<boolean>(this.columnsMovingUrl, JSON.stringify({previousColumnOrderNo, newColumnOrderNo}), httpOptions).pipe(
      tap(result => {
        const outcome = result ? `succeed` : `failed`;
        console.log("moving column "+ outcome)
      }),
      catchError(this.handleError<boolean>('moveColumn'))
  );
  }

    /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
 
      console.error(error);
 
      console.log(`${operation} failed: ${error.message}`);
 
      return of(result as T);
    };
  }
}
