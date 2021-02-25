import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddingGoodsComponent } from './adding-goods.component';

describe('AddingGoodsComponent', () => {
  let component: AddingGoodsComponent;
  let fixture: ComponentFixture<AddingGoodsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddingGoodsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddingGoodsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
