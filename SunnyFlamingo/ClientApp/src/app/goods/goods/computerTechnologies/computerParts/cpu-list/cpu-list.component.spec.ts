import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CPUListComponent } from './cpu-list.component';

describe('CPUListComponent', () => {
  let component: CPUListComponent;
  let fixture: ComponentFixture<CPUListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CPUListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CPUListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
