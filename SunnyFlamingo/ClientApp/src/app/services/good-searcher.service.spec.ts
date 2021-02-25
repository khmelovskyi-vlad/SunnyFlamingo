import { TestBed } from '@angular/core/testing';

import { GoodSearcherService } from './good-searcher.service';

describe('GoodSearcherService', () => {
  let service: GoodSearcherService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GoodSearcherService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
