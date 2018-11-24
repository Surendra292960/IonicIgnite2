import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { ElogPage } from './elog';

@NgModule({
  declarations: [
    ElogPage,
  ],
  imports: [
    IonicPageModule.forChild(ElogPage),
  ],
})
export class ElogPageModule {}
