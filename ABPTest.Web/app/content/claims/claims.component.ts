import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule, DxSelectBoxModule, DxDataGridModule } from 'devextreme-angular';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import { ClaimsService } from './claims.service'
import 'rxjs/add/operator/map';
import 'rxjs/Rx';

@Component({
    selector: 'my-claims',
    templateUrl: './app/content/claims/claims.component.html',
    providers: [ ClaimsService ]
})
export class ClaimsComponent implements OnInit {
    claimToSend: Claim;
    labelLocation: string;
    readOnly: boolean;
    showColon: boolean;
    minColWidth: number;
    colCount: number;
    width: any;
    category: string;
    categories: string[];
    availableCategories: string[] = ["a", "b", "c", "d", "e"];

    constructor(private _claimsService: ClaimsService) {
        this.labelLocation = "top";
        this.readOnly = true;
        this.showColon = true;
        this.minColWidth = 300;
        this.colCount = 2;
        this.category = "a";
        this.categories = [];
    }

    ngOnInit() {
        this.getClaim();
    }

    getClaim() {
        this.claimToSend = new Claim('');
    }
    //Нельзя добавлять 
    addCategoryToArray(category: string) {
        if (!(
            (this.categories.some(x => x == category)) ||
            (this.categories.some(x => x == "a") && (category == "c")) ||
            (this.categories.some(x => x == "c") && (category == "a")) ||
            (this.categories.length >= 3)) 

        ) {
            this.categories.push(category);
        }
    }
}
export class Claim {
    constructor(stringData: string) {
        this.StringData = stringData;
    }
    StringData: string;
}