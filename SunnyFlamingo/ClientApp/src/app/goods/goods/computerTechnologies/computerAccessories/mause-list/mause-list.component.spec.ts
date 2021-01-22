import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MauseListComponent } from './mause-list.component';

describe('MauseListComponent', () => {
  let component: MauseListComponent;
  let fixture: ComponentFixture<MauseListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ MauseListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(MauseListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
