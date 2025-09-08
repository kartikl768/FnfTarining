import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Employee } from '../Models/employee';

@Component({
  selector: 'app-empdetail',
  standalone: false,
  templateUrl: './empdetail.html',
  styleUrl: './empdetail.css'
})
export class Empdetail {
   @Input() selectedEmp : Employee = {} as Employee;
   updatedEmp : Employee = {} as Employee
   @Output() update = new EventEmitter<Employee>()

  onUpdate(){
    this.update.emit(this.updatedEmp);
    alert("Employee updated successfully")
  }
    
}
