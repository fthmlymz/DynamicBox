import { Injectable } from '@angular/core';
import { Subject, Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})

export class MessageService {
  private subject = new Subject<any>();

  sendMessage(message: any) {
    this.subject.next({ message });
  }

  clearMessages() {
    // @ts-ignore
    this.subject.next();
  }

  getMessage(): Observable<any> {
    return this.subject.asObservable();
  }


  /*private siblingMsg = new Subject<string>();
  constructor() { }
  public getMessage(): Observable<string> {
    return this.siblingMsg.asObservable();
  }
  public updateMessage(message: string): void {
    this.siblingMsg.next(message);
  }*/
}

/*import { Injectable } from '@angular/core';
import {BehaviorSubject } from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class MessageService {
  private messageSource = new BehaviorSubject('default mesajjj');
  currentMessage = this.messageSource.asObservable();

  constructor() { }

  changeMessage(message: any){
    this.messageSource.next(message);
  }
}
*/
