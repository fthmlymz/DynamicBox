import { Injectable } from '@angular/core';
import { environment } from '../../../environments/environment';
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private gatewayUrl: string = `${environment.gatewayUrl}`;
  public loading: boolean = true;

  constructor(private httpClient: HttpClient) {}

  public userAuth(_username: string, _password: string) {
    const headers = new HttpHeaders({
      'Content-Type': 'application/x-www-form-urlencoded',
    });
    const body = new HttpParams()
      .set(`client_id`, environment.client_id)
      .set(`grant_type`, environment.grant_type)
      .set(`username`, _username)
      .set(`password`, _password);

    return this.httpClient
      .post<any>(
        `${this.gatewayUrl}/api/services/auth/openid-connect/token`,
        body.toString(),
        { headers: headers }
      )
      .pipe(tap((x) => (this.loading = false)));
  }
}
