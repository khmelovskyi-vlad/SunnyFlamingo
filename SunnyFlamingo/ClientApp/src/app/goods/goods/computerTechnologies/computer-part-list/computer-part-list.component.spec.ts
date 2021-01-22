import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComputerPartListComponent } from './computer-part-list.component';

describe('ComputerPartListComponent', () => {
  let component: ComputerPartListComponent;
  let fixture: ComponentFixture<ComputerPartListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComputerPartListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComputerPartListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
