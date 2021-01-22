import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComputerDriveListComponent } from './computer-drive-list.component';

describe('ComputerDriveListComponent', () => {
  let component: ComputerDriveListComponent;
  let fixture: ComponentFixture<ComputerDriveListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComputerDriveListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComputerDriveListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
