import { Component, OnInit } from '@angular/core';
import { PiServiceService } from 'src/app/services/pi-service.service';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  piDecimals: number[];

  constructor(private piService: PiServiceService) { }

  ngOnInit() {
    this.piDecimals = this.piService.getDecimals();
    console.log('set pi decimals to ' + this.piDecimals)
  }
}
