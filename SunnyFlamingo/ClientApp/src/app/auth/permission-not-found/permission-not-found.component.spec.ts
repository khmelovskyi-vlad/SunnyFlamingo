import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PermissionNotFoundComponent } from './permission-not-found.component';

describe('PermissionNotFoundComponent', () => {
  let component: PermissionNotFoundComponent;
  let fixture: ComponentFixture<PermissionNotFoundComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PermissionNotFoundComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PermissionNotFoundComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
