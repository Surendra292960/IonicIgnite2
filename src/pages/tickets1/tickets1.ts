import { Component } from '@angular/core';
import { Platform } from 'ionic-angular';
import { Page1Page } from '../page1/page1';
import { Page2Page } from '../page2/page2';



@Component({
  selector: 'page-tickets1',
  template: `
  <ion-header>
    <ion-navbar color="dark">
      <ion-title>Tabs</ion-title>
    </ion-navbar>
  </ion-header>
  <ion-content>
  </ion-content>
  `})

export class Tickets1Page {

   isAndroid: boolean = false;

  constructor(platform: Platform) {
    this.isAndroid = platform.is('android');
  }
}

@Component({
  template: `
    <ion-tabs color="dark"
    tabsPlacement="top" class="tabs-basic">
      <ion-tab tabTitle="LOAD" [root]="rootPage1"></ion-tab>
      <ion-tab tabTitle="UNLOAD" [root]="rootPage2"></ion-tab>
    </ion-tabs>
`})
export class BasicPage {
  rootPage1 = Page1Page;
  rootPage2 = Page2Page;
  constructor() {}
}