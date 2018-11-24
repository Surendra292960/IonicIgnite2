import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { JsonFormPage } from './json-form';

@NgModule({
  declarations: [
    JsonFormPage,
  ],
  imports: [
    IonicPageModule.forChild(JsonFormPage),
  ],
})
export class JsonFormPageModule {}
