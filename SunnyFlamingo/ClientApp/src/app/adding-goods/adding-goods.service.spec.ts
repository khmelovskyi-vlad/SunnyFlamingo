import { TestBed } from '@angular/core/testing';

import { AddingGoodsService } from './adding-goods.service';

describe('AddingGoodsService', () => {
  let service: AddingGoodsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AddingGoodsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
