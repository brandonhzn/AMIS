import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-CursosDisp',
  templateUrl: './CursosDisp.component.html',
  styleUrls: ['./CursosDisp.component.css']
})
export class CursosDispComponent implements OnInit {
  @Input() CursosIn:any;
  constructor() { }

  ngOnInit() {
    
  }  

}
