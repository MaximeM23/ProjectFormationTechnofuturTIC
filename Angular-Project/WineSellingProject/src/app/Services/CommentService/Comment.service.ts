import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subscribable } from 'rxjs';
import { CommentToSend } from 'src/app/Models/CommentToSend';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CommentService {


  private url = environment.apiUrl;

  constructor(private _http : HttpClient) { }

  insertNewComment(comment: CommentToSend) : Subscribable<any> {
    return this._http.post(this.url + "Comment",comment);
  }

}
