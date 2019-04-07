import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-decimal-box',
  templateUrl: './decimal-box.component.html',
  styleUrls: ['./decimal-box.component.css']
})
export class DecimalBoxComponent implements OnInit {

  @Input() index: number;
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

  onKey(e: any) {

    let isDigitKeyPress =  (e.keyCode >= 48 && e.keyCode <= 57) || (e.keyCode >= 96 && e.keyCode <= 105)

    if (isDigitKeyPress) {
      // focus on next decimal box
      let element = document.getElementById('dbox'+(this.index+1));
      if(element == null) {
        console.log('sibling not found');
        return;
      }
      else {
        console.log('focusing on sibling');
        element.focus();
      }
    }
  }
}
