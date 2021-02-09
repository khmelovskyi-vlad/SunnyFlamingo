import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GoodCharacteristicComponent } from './good-characteristic.component';

describe('GoodCharacteristicComponent', () => {
  let component: GoodCharacteristicComponent;
  let fixture: ComponentFixture<GoodCharacteristicComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GoodCharacteristicComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GoodCharacteristicComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
