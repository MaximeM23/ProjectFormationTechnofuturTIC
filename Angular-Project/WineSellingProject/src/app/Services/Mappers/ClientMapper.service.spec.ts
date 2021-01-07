/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { ClientMapperService } from './ClientMapper.service';

describe('Service: ClientMapper', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ClientMapperService]
    });
  });

  it('should ...', inject([ClientMapperService], (service: ClientMapperService) => {
    expect(service).toBeTruthy();
  }));
});
