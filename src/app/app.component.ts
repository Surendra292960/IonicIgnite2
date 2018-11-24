import { Component, ViewChild } from '@angular/core';
import { Nav, Platform } from 'ionic-angular';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';

import { HomePage } from '../pages/home/home';
import { ListPage } from '../pages/list/list';
import { SettingPage } from '../pages/setting/setting';
import { ProfilePage } from '../pages/profile/profile';
import { LoginPage } from '../pages/login/login';
import { RegisterPage } from '../pages/register/register';
import { TicketsPage } from '../pages/tickets/tickets';
import { RequisitionPage } from '../pages/requisition/requisition';
import { Tickets1Page, BasicPage } from '../pages/tickets1/tickets1';
import { MapPage } from '../pages/map/map';
import { ColaborationPage } from '../pages/colaboration/colaboration';
import { ElogPage } from '../pages/elog/elog';
import { JsonFormPage } from '../pages/json-form/json-form';
import { JsonCardPage } from '../pages/json-card/json-card';

@Component({
  templateUrl: 'app.html'
})
export class MyApp {
  @ViewChild(Nav) nav: Nav;

  rootPage: any = HomePage;

  pages: Array<{title: string, icon:string, component: any}>;
  pages1: Array<{title: string, icon:string, component: any}>;

  constructor(public platform: Platform, public statusBar: StatusBar, public splashScreen: SplashScreen) {
     
    this.initializeApp();

    // used for an example of ngFor and navigation
    this.pages = [
      { title: 'Home',  icon:'home',component: HomePage },
      { title: 'List',  icon:'list-box',component: ListPage },
      { title: 'Tickets',  icon:'albums', component: TicketsPage },
      { title: 'REQUISITION',  icon:'albums', component: RequisitionPage },
      { title: 'Tabs',  icon:'contact', component: BasicPage },
      { title: 'MAP',  icon:'locate', component: MapPage },
      { title: 'COLABORATION',  icon:'chatbubbles', component: ColaborationPage },
      { title: 'ELOG',  icon:'document', component: ElogPage },
      {title: 'JsonForm', icon:'document', component: JsonFormPage},
      {title: 'JsonCard', icon:'document', component: JsonCardPage}
    ];

    this.pages1 = [
      { title: 'Setting', icon:'settings', component: SettingPage },
      { title: 'Profile', icon:'person', component: ProfilePage },
      { title: 'Register', icon:'person', component: RegisterPage },
      { title: 'Login', icon:'person', component: LoginPage },
    ];

  }

  initializeApp() {
    this.platform.ready().then(() => {
      // Okay, so the platform is ready and our plugins are available.
      // Here you can do any higher level native things you might need.
      this.statusBar.styleDefault();
      this.splashScreen.hide();
    });
  }

  openPage(page) {
    // Reset the content nav to have just this page
    // we wouldn't want the back button to show in this scenario
    this.nav.setRoot(page.component);
  }
}
