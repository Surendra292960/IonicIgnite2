import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams, ShowWhen } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';


@IonicPage()
@Component({
  selector: 'page-setting',
  templateUrl: 'setting.html',
})
export class SettingPage {

  public items:any;

  constructor(public navCtrl: NavController, public navParams: NavParams, public http: HttpClient) {
   this.items=[
     {title:"john", id:1},
     {title:"Suree", id:2},
     {title:"Jay", id:3},
     {title:"Harish", id:4},
     {title:"Alka", id:5},
     {title:"Sonu", id:6},
     {title:"Vivek", id:7},
     {title:"Slem", id:8},
     {title:"Veeru", id:9},
     {title:"john", id:10},
     {title:"john", id:11},
     {title:"john", id:12},
   ]

 // this.loadData();
  }
  // loadData(){
  //   let data:Observable<any>
  //   data=this.http.get('https://jsonplaceholder.typicode.com/posts');
  //   data.subscribe(result =>{
  //     this.items = result
  //   })
  // }
// ItemClicked(itemid:number){
//   alert(itemid);
// }

Dismiss(){
  this.navCtrl.getPrevious();
}
}
