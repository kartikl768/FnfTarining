import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { CommonModule } from '@angular/common';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Second } from './Component/second/second';
import { Calc } from './Component/calc/calc';
import { FormsModule } from '@angular/forms';
import { Master } from './Component/master/master';
import { Empdetail } from './Component/empdetail/empdetail';
import { ValidatioForm } from './validatio-form/validatio-form';
import { Navbar } from './navbar/navbar';

@NgModule({
  declarations: [
    App,
    Second,
    Calc,
    Master,
    Empdetail,
    ValidatioForm,
    Navbar
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CommonModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
