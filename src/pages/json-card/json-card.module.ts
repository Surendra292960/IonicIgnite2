import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { JsonCardPage } from './json-card';

@NgModule({
  declarations: [
    JsonCardPage,
  ],
  imports: [
    IonicPageModule.forChild(JsonCardPage),
  ],
})
export class JsonCardPageModule {}
