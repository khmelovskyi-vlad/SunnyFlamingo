import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ImageMasterComponent } from './image-master.component';

describe('ImageMasterComponent', () => {
  let component: ImageMasterComponent;
  let fixture: ComponentFixture<ImageMasterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ImageMasterComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ImageMasterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
