import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';



@IonicPage()
@Component({
  selector: 'page-json-form',
  templateUrl: 'json-form.html',
})
export class JsonFormPage {

  constructor(public navCtrl: NavController, public navParams: NavParams) {
  }

  data={"required":["Load_Type","Company Name"],
  "properties":{
    "Load_Type":{"lable":"Load Type",
                  "type":"text",
                  "class":"secondry-content",
                  "values":["10","10"]
                },
     "Company_Name":{"lable":"Company Name",
                  "type":"text",
                  "class":"secondry-content",
                  "values":["10","10"]
              },
     "Consigner_Name":{"lable":"Consigner",
                  "type":"text",
                  "class":"secondry-content",
                  "values":["10","10"]
                }, 
     "Dagerous_Name":{"lable":"Dagerous Godds",
                   "type":"text",
                   "class":"secondry-content",
                   "values":["10","10"]
                },
      "Tank_Selection":{"lable":"Tank_Selection","value":"Tank_Selection",
                    "type":"text",
                    "class":"secondry-content",
                    "values":["ticket1","ticket2"]
                }, 
      "Arrival_Selection":{"lable":"Arrival_Selection","value":"Arrival_Selection",
                   "type":"text",
                   "class":"secondry-content",
                   "values":["2:PM","4:PM"]
                }, 
       "Finish_Selection":{"lable":"Finish_Selection","value":"Finish_Selection",
                   "type":"text",
                   "class":"secondry-content",
                    "values":["full","half"]
                },                 
          }
    }

}
