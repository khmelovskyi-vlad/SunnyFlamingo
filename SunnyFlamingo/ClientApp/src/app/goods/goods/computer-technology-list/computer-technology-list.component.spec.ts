import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ComputerTechnologyListComponent } from './computer-technology-list.component';

describe('ComputerTechnologyListComponent', () => {
  let component: ComputerTechnologyListComponent;
  let fixture: ComponentFixture<ComputerTechnologyListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ComputerTechnologyListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ComputerTechnologyListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
