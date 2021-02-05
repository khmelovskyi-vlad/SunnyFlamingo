import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodsMenuComponent } from './goods-menu.component';

describe('GoodsMenuComponent', () => {
  let component: GoodsMenuComponent;
  let fixture: ComponentFixture<GoodsMenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodsMenuComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodsMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
