import { Pipe, PipeTransform } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Constantes } from '../util/Constantes';

@Pipe({
  name: 'DateTimeFormartPipe'
})
export class DateTimeFormartPipePipe extends DatePipe implements PipeTransform {

  transform(value: any, args?: any): any {
    return super.transform(value, Constantes.DATE_TIME_FMT);
  }

}
