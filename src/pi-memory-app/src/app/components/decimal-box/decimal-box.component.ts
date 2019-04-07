import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-decimal-box',
  templateUrl: './decimal-box.component.html',
  styleUrls: ['./decimal-box.component.css']
})
export class DecimalBoxComponent implements OnInit {

  expectedValue: number;
  actualValue: number;

  constructor() { }

  ngOnInit() {
  }  
}
