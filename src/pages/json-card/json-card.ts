import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { Observable } from 'rxjs/Observable';
import { HttpClient } from '@angular/common/http';



@IonicPage()
@Component({
  selector: 'page-json-card',
  templateUrl: 'json-card.html',
})
export class JsonCardPage {
 
  public items:any;
  constructor(public navCtrl: NavController, public navParams: NavParams, public http:HttpClient) {

  this.getData();
}
  getData(){
   let url= 'https://jsonplaceholder.typicode.com/photos';
   let data:Observable<any> = this.http.get(url);
   data.subscribe(result =>{
    this.items = result
   })
 }
 ItemClicked(itemid:number){
   alert(itemid);
 }

}
