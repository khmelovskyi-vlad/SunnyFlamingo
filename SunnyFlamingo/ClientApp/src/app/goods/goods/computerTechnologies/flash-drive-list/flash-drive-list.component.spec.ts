import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlashDriveListComponent } from './flash-drive-list.component';

describe('FlashDriveListComponent', () => {
  let component: FlashDriveListComponent;
  let fixture: ComponentFixture<FlashDriveListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlashDriveListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlashDriveListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
