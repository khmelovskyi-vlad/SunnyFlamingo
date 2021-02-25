import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { QuestionBase } from '../../models/question-base';
import { InputType } from '../../value-objects/input-type';

@Component({
  selector: 'app-image-master',
  templateUrl: './image-master.component.html',
  styleUrls: ['./image-master.component.css']
})
export class ImageMasterComponent implements OnInit {

  @Input()questionsKey: string;
  @Input()question: QuestionBase<string>;
  @Input()formGroup: FormGroup;
  InputType = InputType;
  @Output() addImagesEvent = new EventEmitter<File[]>();
  
  addImages(event: any){
    if (event.target.files.length > 0) {
      const fileArray: File[] = [];
      for (let file of event.target.files) {
        fileArray.push(file);
      }
      this.addImagesEvent.emit(fileArray);
    }
  }

  constructor() { }
  
  ngOnInit(): void {}

}
