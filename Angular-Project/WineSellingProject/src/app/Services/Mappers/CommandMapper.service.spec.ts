/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { CommandMapperService } from './CommandMapper.service';

describe('Service: CommandMapper', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [CommandMapperService]
    });
  });

  it('should ...', inject([CommandMapperService], (service: CommandMapperService) => {
    expect(service).toBeTruthy();
  }));
});
