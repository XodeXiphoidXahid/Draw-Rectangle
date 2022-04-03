import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Rectangle } from '../models/rectangle.model';

@Injectable({
  providedIn: 'root'
})
export class RectangleService {

  getUrl='https://localhost:44316/api/rectangle';

  constructor(private http: HttpClient) { }

  //get
  getRectangleProperties(): Observable<Rectangle>{
      return this.http.get<Rectangle>(this.getUrl);
  }
}

