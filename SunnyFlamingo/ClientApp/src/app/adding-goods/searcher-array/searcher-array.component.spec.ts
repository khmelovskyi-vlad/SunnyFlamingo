import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearcherArrayComponent } from './searcher-array.component';

describe('SearcherArrayComponent', () => {
  let component: SearcherArrayComponent;
  let fixture: ComponentFixture<SearcherArrayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearcherArrayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SearcherArrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
