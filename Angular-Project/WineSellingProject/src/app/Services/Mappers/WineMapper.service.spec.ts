/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { WineMapperService } from './WineMapper.service';

describe('Service: WineMapper', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [WineMapperService]
    });
  });

  it('should ...', inject([WineMapperService], (service: WineMapperService) => {
    expect(service).toBeTruthy();
  }));
});
