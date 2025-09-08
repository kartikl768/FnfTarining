import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Calc } from './Component/calc/calc';
import { Empdetail } from './Component/empdetail/empdetail';
import { Master } from './Component/master/master';
import { Second } from './Component/second/second';
import { ValidatioForm } from './validatio-form/validatio-form';

const routes: Routes = [
  {path: "", redirectTo:"/home", pathMatch:"full"},
  {path: "calc", component: Calc},
  {path: "emp", component:Empdetail},
  {path: "empview", component:Master},
  {path: "second", component:Second},
  {path: "validation", component:ValidatioForm}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
