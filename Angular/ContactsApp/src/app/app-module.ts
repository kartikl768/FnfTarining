import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { ContactView } from './Components/contact-view/contact-view';
import { ContactList } from './Components/contact-list/contact-list';
import { EditContact } from './Components/edit-contact/edit-contact';
import { ErrorPage } from './Components/error-page/error-page';
import { Navbar } from './Components/navbar/navbar';
import { NewContact } from './Components/new-contact/new-contact';
import { HttpClient, provideHttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ContactfilterPipe } from './Pipes/contactfilter-pipe';

@NgModule({
  declarations: [
    App,
    ContactView,
    ContactList,
    EditContact,
    ErrorPage,
    Navbar,
    NewContact,
    ContactfilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners(),
    provideHttpClient()
  ],
  bootstrap: [App]
})
export class AppModule { }
