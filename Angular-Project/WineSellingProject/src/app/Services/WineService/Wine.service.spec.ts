/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { WineService } from './Wine.service';

describe('Service: Wine', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WineService]
    });
  });

  it('should ...', inject([WineService], (service: WineService) => {
    expect(service).toBeTruthy();
  }));
});
