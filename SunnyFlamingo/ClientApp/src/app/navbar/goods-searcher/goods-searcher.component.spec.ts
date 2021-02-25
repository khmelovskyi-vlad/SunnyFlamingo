import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodsSearcherComponent } from './goods-searcher.component';

describe('GoodsSearcherComponent', () => {
  let component: GoodsSearcherComponent;
  let fixture: ComponentFixture<GoodsSearcherComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodsSearcherComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodsSearcherComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
