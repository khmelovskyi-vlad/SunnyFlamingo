import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodCharacteristicListComponent } from './good-characteristic-list.component';

describe('GoodCharacteristicListComponent', () => {
  let component: GoodCharacteristicListComponent;
  let fixture: ComponentFixture<GoodCharacteristicListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodCharacteristicListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodCharacteristicListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
