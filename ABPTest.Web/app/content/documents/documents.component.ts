import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule } from 'devextreme-angular';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { StudentDocumentService } from "./documents.service";
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

@Component({
    selector: 'my-documents',
    templateUrl: './app/content/documents/documents.component.html',
    providers: [ StudentDocumentService ]
})
export class DocumentsComponent implements OnInit {
    studentDocumentOutput: StudentDocument;
    studentDocumentInput: StudentDocument;
    labelLocation: string;
    readOnly: boolean;
    showColon: boolean;
    minColWidth: number;
    colCount: number;
    width: any;

    constructor(private _studentDocumentService: StudentDocumentService) {
        this.labelLocation = "top";
        this.readOnly = true;
        this.showColon = true;
        this.minColWidth = 300;
        this.colCount = 2;
        this.studentDocumentInput = new StudentDocument("Наименование", "Номер")
    }

    errorMessage: string;

    ngOnInit() {
        this.getStudentDocument();
    }

    getStudentDocument() {
        this._studentDocumentService.getStudentDocument()
            .subscribe(
            value => this.studentDocumentOutput = value,
            error => this.errorMessage = <any>error);
    }

    postStudentDocument(documentToPost) {
        console.log(JSON.stringify(documentToPost));
        this._studentDocumentService.postStudentDocument(JSON.stringify(documentToPost));
    }

}

export class StudentDocument {
    constructor(name: string, number: string) {
        this.Name = name;
        this.Number = number;
    }
    Name: string;
    Number: string;
    Id: number;
}