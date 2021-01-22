import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodCellComponent } from './good-cell.component';

describe('GoodCellComponent', () => {
  let component: GoodCellComponent;
  let fixture: ComponentFixture<GoodCellComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodCellComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodCellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
