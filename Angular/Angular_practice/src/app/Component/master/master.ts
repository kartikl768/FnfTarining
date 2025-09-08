import { Component, OnInit } from '@angular/core';
import { Employee } from '../Models/employee';

@Component({
  selector: 'app-master',
  standalone: false,
  templateUrl: './master.html',
  styleUrl: './master.css'
})
export class Master implements OnInit{
  ngOnInit(): void {
    this.empList.push({empId : 123, empName: "John", empAddress : "Bengaluru", empSalary : 696969, empImg : "pic1.png"});
    this.empList.push({empId : 124, empName: "Lisa", empAddress : "Mysuru", empSalary : 69669, empImg : "pic2.png"});
    this.empList.push({empId : 125, empName: "Wayne", empAddress : "Ooty", empSalary : 60069, empImg : "pic3.png"});
    this.empList.push({empId : 126, empName: "Kanye", empAddress : "LA", empSalary : 696900, empImg : "pic4.png"});
    this.empList.push({empId : 127, empName: "Mitchelle", empAddress : "California", empSalary : 9000, empImg : "pic5.png"});
  }
  empList : Employee[] = []; //create an Emp Array and initialize to blank
  foundEmp: Employee = {} as Employee;

  onEdit(rec: Employee){
    this.foundEmp =rec;
  }
  onSaved(rec : Employee){
    var index = this.empList.findIndex(r => r.empId==rec.empId);
    if(index<0){
      alert("Employee Not found");
      return;
    }
    this.empList.splice(index,1,rec);
    alert("Employee updated")
  }
}
