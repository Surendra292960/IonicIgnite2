import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { HttpClientModule } from '@angular/common/http';

import { FormsModule } from '@angular/forms';
import { MyApp } from './app.component';
import { HomePage } from '../pages/home/home';
import { ListPage } from '../pages/list/list';

import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { SettingPage } from '../pages/setting/setting';
import { ProfilePage } from '../pages/profile/profile';
import { AuthServiceProvider } from '../providers/auth-service/auth-service';
import { RegisterPage } from '../pages/register/register';
import { LoginPage } from '../pages/login/login';
import { TicketsPage } from '../pages/tickets/tickets';
import { RequisitionPage } from '../pages/requisition/requisition';
import { Tickets1Page, BasicPage } from '../pages/tickets1/tickets1';
import { Page1Page } from '../pages/page1/page1';
import { Page2Page } from '../pages/page2/page2';
import { Page3Page } from '../pages/page3/page3';
import { MapPage } from '../pages/map/map';
import { ColaborationPage } from '../pages/colaboration/colaboration';
import { ElogPage } from '../pages/elog/elog';
import { RestProvider } from '../providers/rest/rest';
import { JsonFormPage } from '../pages/json-form/json-form';
import { JsonCardPage } from '../pages/json-card/json-card';




@NgModule({
  declarations: [
    MyApp,
    HomePage,
    ListPage,
    SettingPage,
    ProfilePage,
    RegisterPage,
    LoginPage,
    TicketsPage,
    RequisitionPage,
    Tickets1Page,BasicPage,Page1Page,Page2Page,Page3Page,    
    MapPage,ColaborationPage,ElogPage,JsonFormPage,JsonCardPage,

  ],
  imports: [
    FormsModule,
    BrowserModule,
    HttpClientModule,
    IonicModule.forRoot(MyApp),
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    HomePage,
    ListPage,
    SettingPage,
    ProfilePage,
    RegisterPage,
    LoginPage,
    TicketsPage,
    RequisitionPage,
    Tickets1Page,BasicPage,Page1Page,Page2Page,Page3Page,
    MapPage,ColaborationPage,ElogPage,JsonFormPage,JsonCardPage,

  ],
  providers: [
    StatusBar,
    SplashScreen,
    {provide: ErrorHandler, useClass: IonicErrorHandler},
    AuthServiceProvider,
    RestProvider
  ]
})
export class AppModule {}
