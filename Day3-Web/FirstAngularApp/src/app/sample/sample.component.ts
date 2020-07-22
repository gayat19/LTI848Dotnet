import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sample',
  template: `<input type="text" #username>
            <button (click)="addName(username)">AddName</button>
              <div *ngFor="let name of names">{{name}}</div>`,
  styles: [`div{background-color:'blue'}`]
})
export class SampleComponent implements OnInit {
names:string[];
  constructor() { 
    this.names=["Ramu","Somu"]
  }
  addName(un){
    this.names.push(un.value);
  }
  ngOnInit(): void {
  }

}
