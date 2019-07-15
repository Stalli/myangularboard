import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CardComponent } from './components/card/card.component';
import { ColumnsComponent } from './components/columns/columns.component';

const routes: Routes = [
  { path: '', component: ColumnsComponent },
  { path: 'card/:id', component: CardComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
