import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Comp1Component } from './comp1/comp1.component';

//const routes: Routes = [];

const routes: Routes = [
  {
    path: "Component1", component: Comp1Component
  }
  //{
  //  path: "Contact", component: ContactComponent
  //},
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
