import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { CardComponent } from './components/card/card.component';
import { SignInComponent } from './components/sign-in/sign-in.component';
import { ColumnsComponent } from './components/columns/columns.component';

const routes: Routes = [
  { path: '', component: SignInComponent },
  { path: 'card/:id', component: CardComponent },
  { path: 'columns', component: ColumnsComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
