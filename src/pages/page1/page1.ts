import { Component,OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams  } from 'ionic-angular';

declare let $ ; 



@IonicPage()
@Component({
  selector: 'page-page1',
  templateUrl: 'page1.html',
})
export class Page1Page implements OnInit {

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  ngOnInit() {
    $("#item-divider").click(function(){
      $("FabDIsplay").toggle();
  });
}
  ionViewDidLoad() {
    console.log('ionViewDidLoad Page1Page');
  }





  data={"required":["Load_Type","Company Name"],
  "properties":{
    "Load_Type":{"lable":"Load Type",
                  "type":"text",
                  "class":"secondry-content"
                },
     "Company_Name":{"lable":"Company Name",
                  "type":"text",
                  "class":"secondry-content",
                  
              },
     "Consigner_Name":{"lable":"Consigner",
                  "type":"text",
                  "class":"secondry-content",
              }, 
          
     "Dagerous_Name":{"lable":"Dagerous Godds",
                   "type":"text",
                   "class":"secondry-content",
                },
      "Take_Selection":{"lable":"Take_Selection",
                   "type":"text",
                    "class":"secondry-content",
             },                 

       }
    }
}
