import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-churras',
  templateUrl: './churras.component.html',
  styleUrls: ['./churras.component.css']
})
export class ChurrasComponent implements OnInit {

  title = 'Churrascos';

  churrascos: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getAllChurrascos();
  }

  getAllChurrascos(){
   this.http.get('http://localhost:51928/getAll').subscribe(
     response => {this.churrascos = response;
    console.log(response);},
    error => {console.log(error)},
   );
  }

}
