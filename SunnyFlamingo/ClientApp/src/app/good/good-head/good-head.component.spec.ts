import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodHeadComponent } from './good-head.component';

describe('GoodHeadComponent', () => {
  let component: GoodHeadComponent;
  let fixture: ComponentFixture<GoodHeadComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodHeadComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodHeadComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
