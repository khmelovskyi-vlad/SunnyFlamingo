import { TestBed } from '@angular/core/testing';

import { AddingGoodsGuard } from './adding-goods.guard';

describe('AddingGoodsGuard', () => {
  let guard: AddingGoodsGuard;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    guard = TestBed.inject(AddingGoodsGuard);
  });

  it('should be created', () => {
    expect(guard).toBeTruthy();
  });
});
