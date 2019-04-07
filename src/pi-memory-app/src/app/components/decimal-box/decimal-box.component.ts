import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-decimal-box',
  templateUrl: './decimal-box.component.html',
  styleUrls: ['./decimal-box.component.css']
})
export class DecimalBoxComponent implements OnInit {

  @Input() expectedValue: number;
  actualValue: string;

  constructor() { }

  ngOnInit() {
  }

  isCorrect(): boolean {
    return String(this.expectedValue) === this.actualValue;
  }

  isWrong(): boolean {
    return !this.isCorrect() && this.actualValue !== undefined; 
  }
}
