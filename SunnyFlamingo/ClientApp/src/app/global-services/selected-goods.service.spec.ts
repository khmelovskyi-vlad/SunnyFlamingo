import { TestBed } from '@angular/core/testing';

import { SelectedGoodsService } from './selected-goods.service';

describe('SelectedGoodsService', () => {
  let service: SelectedGoodsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SelectedGoodsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
