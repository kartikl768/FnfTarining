import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  standalone: false,
  templateUrl: './calc.html',
  styleUrl: './calc.css'
})
export class Calc {
  fval : number = 20.86;
  sval : number = 68.42;
  option : string = "Add"
  result : number =0.0;
  onProcess(){
    switch(this.option){
      case "Add": this.fval+this.sval; break;
      case "Subtract": this.fval-this.sval; break;
      case "Multiply": this.fval*this.sval; break;
      case "Divide": this.fval/this.sval; break;
    }
  }
}
