import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { Tickets1Page, BasicPage } from './tickets1';

@NgModule({
  declarations: [
    Tickets1Page,
    BasicPage
  ],
  imports: [
    IonicPageModule.forChild(BasicPage),
  ],
})
export class Tickets1PageModule {}
