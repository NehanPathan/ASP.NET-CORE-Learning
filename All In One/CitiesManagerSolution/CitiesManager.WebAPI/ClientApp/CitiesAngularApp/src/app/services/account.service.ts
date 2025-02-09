import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LoginUser } from '../models/login-user';
import { RegisterUser } from '../models/register-user';

const API_BASE_URL: string = "https://localhost:7082/api/v1/account/";

@Injectable({
  providedIn: 'root'
})
export class AccountService {
  public currentUserName: string | null = null;


  constructor(private httpClient: HttpClient) {
  }

  public postRegister(registerUser: RegisterUser): Observable<any> {
    return this.httpClient.post<RegisterUser>(`${API_BASE_URL}register`, registerUser);
  }

  public postLogin(loginUser: LoginUser): Observable<any> {
    return this.httpClient.post<any>(`${API_BASE_URL}login`, loginUser);
  }

  public getLogout(): Observable<string> {
    return this.httpClient.get<string>(`${API_BASE_URL}logout`);
  }
}
