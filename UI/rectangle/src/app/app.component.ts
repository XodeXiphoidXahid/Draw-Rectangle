import { Component, OnInit } from '@angular/core';
import { Rectangle } from './models/rectangle.model';
import { RectangleService } from './service/rectangle.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'rectangle';


  
  rect: any;  
  width: 50;
  height: 50;
  constructor(private rectangleService: RectangleService){
  }
  ngOnInit(): void {
    this.getRectangle();
  }
  getRectangle(){
    this.rectangleService.getRectangleProperties().subscribe(
      response =>{
        this.rect=response;
      }
    )
  }
}
