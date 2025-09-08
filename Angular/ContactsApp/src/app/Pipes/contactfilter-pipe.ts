import { Pipe, PipeTransform } from '@angular/core';
import { contact } from '../Models/contact';

@Pipe({
  name: 'contactfilter',
  standalone: false
})
export class ContactfilterPipe implements PipeTransform {

  //1st : Source
  //2nd: arg /conditions for transformation. 
  //Return type: What U expect after the transformation
  transform(contacts: contact[], args: string): contact[] {
    if(args==""){
      return contacts;
    }else{
      return contacts.filter(c=>c.contactName.toLowerCase().includes(args.toLowerCase()));
    }
  }

}
