import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PiServiceService {

  constructor() { }

  getDecimals(): number[] {
    return [1,4,1,5,9,2];
  }
}
