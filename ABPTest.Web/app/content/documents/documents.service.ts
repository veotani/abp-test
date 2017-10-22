import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule } from 'devextreme-angular';
import { Http, Response, Headers } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

import { StudentDocument } from "./documents.component";

@Injectable()
export class StudentDocumentService {
    private _documentUrl = 'http://localhost:6234/api/services/tasksystem/document/GetDocumentById';
    private _documentPostUrl = 'http://localhost:6234/api/services/tasksystem/document/PostDocument';

    constructor(private _http: Http) { }

    getStudentDocument(): Observable<StudentDocument> {

        return this._http.get(this._documentUrl)
            //.map(res => <StudentDocument>res.json()['result'])
            .map(res => <StudentDocument>res.json().result)
            .catch(this.handleError);
    }
    private handleError(error: Response) {
        console.error(error);
        return Observable.throw(error.json().error || 'Server error')
    }
    postStudentDocument(documentInput) {
        let headers = new Headers({ 'Content-Type': 'application/json;charset=utf-8' });
        this._http.post(this._documentPostUrl, documentInput, { headers: headers }).subscribe();
    }
}