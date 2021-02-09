import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodAboutRightComponent } from './good-about-right.component';

describe('GoodAboutRightComponent', () => {
  let component: GoodAboutRightComponent;
  let fixture: ComponentFixture<GoodAboutRightComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodAboutRightComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodAboutRightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
