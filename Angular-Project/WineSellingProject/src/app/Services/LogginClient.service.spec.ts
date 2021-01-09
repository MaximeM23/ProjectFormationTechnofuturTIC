/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { LogginClientService } from './LogginClient.service';

describe('Service: LogginClient', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [LogginClientService]
    });
  });

  it('should ...', inject([LogginClientService], (service: LogginClientService) => {
    expect(service).toBeTruthy();
  }));
});
