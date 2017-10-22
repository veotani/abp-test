import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule } from 'devextreme-angular';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { PersonService } from './person.service'
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

@Component({
    selector: 'my-data',
    templateUrl: './app/content/data/data.component.html',
    providers: [PersonService]
})
export class DataComponent implements OnInit {
    person: Person;
    labelLocation: string;
    readOnly: boolean;
    showColon: boolean;
    minColWidth: number;
    colCount: number;
    width: any;

    constructor(private _personservice: PersonService) {        
        this.labelLocation = "top";
        this.readOnly = true;
        this.showColon = true;
        this.minColWidth = 300;
        this.colCount = 2;
    }
    helloWorld(): void {
        alert('Hello world!');
    }

    errorMessage: string;

    ngOnInit() {
        this.getPerson();
    }

    getPerson() {
        this._personservice.getPerson()
            .subscribe(
            value => this.person = value,
            error => this.errorMessage = <any>error);
    }

}

export class Person {
    FullName: string;
    BithDate: string;
    Sex: string;
    INN: string;
    Id: number;
}



