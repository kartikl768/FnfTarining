import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { contact } from '../Models/contact';

@Injectable({
  providedIn: 'root'
})
export class ContactService {
  // url: string = "http://localhost:3000/contacts";
  url: string ="http://localhost:4000/contacts";
  constructor(private httpClient: HttpClient){

  }
  public getAllContacts() :Observable<contact[]>{
    return this.httpClient.get<contact[]>(this.url);
  }

  public getContact(id: string) : Observable<contact>{
    const temp: string = `${this.url}/${id}`
    return this.httpClient.get<contact>(temp)
  }
  public updateContact(contact: any) : Observable<contact>{
    const url=`${this.url}/${contact.id}`
    return this.httpClient.put<contact>(url,contact);
  }
  public addContact(contact : any) : Observable<contact>{
    return this.httpClient.post<contact>(this.url,contact);
  }
  public deleteContact(id: number): Observable<contact>{
    const temp  = `${this.url}/${id}`
    return this.httpClient.delete<contact>(temp);
  }
}
