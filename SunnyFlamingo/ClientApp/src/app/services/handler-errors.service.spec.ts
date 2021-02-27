import { TestBed } from '@angular/core/testing';

import { HandlerErrorsService } from './handler-errors.service';

describe('HandlerErrorsService', () => {
  let service: HandlerErrorsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HandlerErrorsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
