import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventComponent } from './event/event.component';
import { EventListComponent } from './event-list/event-list.component';

const routes: Routes = [
  {
    path: '',
    component: EventListComponent
  },
  {
    path: 'event',
    component: EventComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
