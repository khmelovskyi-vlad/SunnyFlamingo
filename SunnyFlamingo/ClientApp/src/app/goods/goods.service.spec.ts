import { TestBed } from '@angular/core/testing';

import { GoodsService } from './goods.service';

describe('GoodService', () => {
  let service: GoodsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GoodsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
