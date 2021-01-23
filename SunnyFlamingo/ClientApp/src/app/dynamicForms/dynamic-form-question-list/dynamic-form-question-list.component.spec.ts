import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DynamicFormQuestionListComponent } from './dynamic-form-question-list.component';

describe('DynamicFormQuestionListComponent', () => {
  let component: DynamicFormQuestionListComponent;
  let fixture: ComponentFixture<DynamicFormQuestionListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DynamicFormQuestionListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DynamicFormQuestionListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
