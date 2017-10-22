import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule } from 'devextreme-angular';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/Rx';
import { Person } from './data.component'

@Injectable()
export class PersonService {
    private _personUrl = 'http://localhost:6234/api/services/tasksystem/student/GetStudent';

    constructor(private _http: Http) { }

    getPerson(): Observable<Person> {
        return this._http.get(this._personUrl)
            .map(res => <Person>res.json()['result'])
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error')
    }
}