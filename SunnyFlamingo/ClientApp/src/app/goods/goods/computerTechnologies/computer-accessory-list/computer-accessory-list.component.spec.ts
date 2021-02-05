import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComputerAccessoryListComponent } from './computer-accessory-list.component';

describe('ComputerAccessoryListComponent', () => {
  let component: ComputerAccessoryListComponent;
  let fixture: ComponentFixture<ComputerAccessoryListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComputerAccessoryListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComputerAccessoryListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
