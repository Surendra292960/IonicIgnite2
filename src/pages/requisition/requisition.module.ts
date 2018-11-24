import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { RequisitionPage } from './requisition';

@NgModule({
  declarations: [
    RequisitionPage,
  ],
  imports: [
    IonicPageModule.forChild(RequisitionPage),
  ],
})
export class RequisitionPageModule {}
