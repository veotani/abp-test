import { Component, Injectable, OnInit } from '@angular/core';
import { DxFormModule } from 'devextreme-angular';
import { Http, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/Rx';
import { Claim } from './claims.component';

@Injectable()
export class ClaimsService {
    private postClaimUrl = '';

    constructor(private _http: Http) { }

    postClaim(claim) {
        
    }
}