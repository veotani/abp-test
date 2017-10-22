"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const http_1 = require("@angular/http");
const Observable_1 = require("rxjs/Observable");
require("rxjs/add/operator/map");
require("rxjs/Rx");
let StudentDocumentService = class StudentDocumentService {
    constructor(_http) {
        this._http = _http;
        this._documentUrl = 'http://localhost:6234/api/services/tasksystem/document/GetDocumentById';
        this._documentPostUrl = 'http://localhost:6234/api/services/tasksystem/document/PostDocument';
    }
    getStudentDocument() {
        return this._http.get(this._documentUrl)
            .map(res => res.json().result)
            .catch(this.handleError);
    }
    handleError(error) {
        console.error(error);
        return Observable_1.Observable.throw(error.json().error || 'Server error');
    }
    postStudentDocument(documentInput) {
        let headers = new http_1.Headers({ 'Content-Type': 'application/json;charset=utf-8' });
        this._http.post(this._documentPostUrl, documentInput, { headers: headers }).subscribe();
    }
};
StudentDocumentService = __decorate([
    core_1.Injectable(),
    __metadata("design:paramtypes", [http_1.Http])
], StudentDocumentService);
exports.StudentDocumentService = StudentDocumentService;
//# sourceMappingURL=documents.service.js.map