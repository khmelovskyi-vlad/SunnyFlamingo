import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodImgsComponent } from './good-imgs.component';

describe('GoodImgsComponent', () => {
  let component: GoodImgsComponent;
  let fixture: ComponentFixture<GoodImgsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodImgsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodImgsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
