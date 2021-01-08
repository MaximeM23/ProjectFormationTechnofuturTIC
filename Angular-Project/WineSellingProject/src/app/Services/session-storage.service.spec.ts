/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SessionStorageService } from './session-storage.service';

describe('Service: SessionStorage', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SessionStorageService]
    });
  });

  it('should ...', inject([SessionStorageService], (service: SessionStorageService) => {
    expect(service).toBeTruthy();
  }));
});
