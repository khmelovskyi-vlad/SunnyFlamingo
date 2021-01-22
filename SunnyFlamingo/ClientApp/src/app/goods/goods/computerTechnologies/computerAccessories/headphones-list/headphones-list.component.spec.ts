import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HeadphonesListComponent } from './headphones-list.component';

describe('HeadphonesListComponent', () => {
  let component: HeadphonesListComponent;
  let fixture: ComponentFixture<HeadphonesListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HeadphonesListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HeadphonesListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
