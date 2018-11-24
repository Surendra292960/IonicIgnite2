import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Page3Page } from '../page3/page3';

/**
 * Generated class for the RequisitionPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-requisition',
  templateUrl: 'requisition.html',
})
export class RequisitionPage {

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ionViewDidLoad() {
    console.log('RequisitionPage');
  }

  public reqisition()
  {
    console.log("requisition");
    this.navCtrl.push(Page3Page);
  }

}
