import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodTypeComponent } from './good-type.component';

describe('GoodTypeComponent', () => {
  let component: GoodTypeComponent;
  let fixture: ComponentFixture<GoodTypeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodTypeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
