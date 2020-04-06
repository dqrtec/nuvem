import { Injectable } from '@angular/core';
import { Observable, of} from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators' ;
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { User } from "../model/user"

@Injectable({
  providedIn: 'root'
})
export class UserService {
  url = 'localhost:3000/user';
  private httpOptions = {
    headers: new HttpHeaders({'Content-type': 'application/json'})
  };

  constructor(private http: HttpClient) { }

  getUsers(): Observable<User[]>{
    return this.http.get<User[]>(this.url, this.httpOptions)
            .pipe(
              tap(() => console.log("get users")),
              catchError(this.handleError<User[]>('getUsers', []))
            )
  }

  getUser(apelido: string): Observable<User>{
    return this.http.get<User>(`${this.url}?user=${apelido}`, this.httpOptions)
            .pipe(
              tap(user => console.log('get user: '+ user.user)),
              catchError(this.handleError<User>('getUser'))
            )
  }



  private handleError<T>(operation = 'operation', result?: T){
    return (error: any): Observable<T> => {
      console.log(`${operation} failed: ${error.message}`);
      console.log(error);

      return of (result as T);
    }
  }
}
