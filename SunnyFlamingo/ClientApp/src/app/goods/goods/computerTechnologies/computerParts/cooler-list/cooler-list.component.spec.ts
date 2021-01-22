import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CoolerListComponent } from './cooler-list.component';

describe('CoolerListComponent', () => {
  let component: CoolerListComponent;
  let fixture: ComponentFixture<CoolerListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CoolerListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CoolerListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
