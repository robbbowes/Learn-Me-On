import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'lessonStatus'
})
export class LessonStatusPipe implements PipeTransform {

  transform(value: number): string {
    switch (value) {
      case 0:
        return "Not started"
      case 1:
        return "Listen Blind"
      default:
        break;
    }
  }

}