import { TestBed } from '@angular/core/testing';

import { PiServiceService } from './pi-service.service';

describe('PiServiceService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PiServiceService = TestBed.get(PiServiceService);
    expect(service).toBeTruthy();
  });
});
