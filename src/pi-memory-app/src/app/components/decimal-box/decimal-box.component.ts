import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-decimal-box',
  templateUrl: './decimal-box.component.html',
  styleUrls: ['./decimal-box.component.css']
})
export class DecimalBoxComponent implements OnInit {

  @Input() expectedValue: number;
  actualValue: number;

  constructor() { }

  ngOnInit() {
  }  
}
