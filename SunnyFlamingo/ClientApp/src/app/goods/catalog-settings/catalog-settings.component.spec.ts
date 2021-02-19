import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CatalogSettingsComponent } from './catalog-settings.component';

describe('CatalogSettingsComponent', () => {
  let component: CatalogSettingsComponent;
  let fixture: ComponentFixture<CatalogSettingsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CatalogSettingsComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CatalogSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
