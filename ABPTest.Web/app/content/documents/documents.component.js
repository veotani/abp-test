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
const documents_service_1 = require("./documents.service");
require("rxjs/add/operator/map");
require("rxjs/Rx");
let DocumentsComponent = class DocumentsComponent {
    constructor(_studentDocumentService) {
        this._studentDocumentService = _studentDocumentService;
        this.labelLocation = "top";
        this.readOnly = true;
        this.showColon = true;
        this.minColWidth = 300;
        this.colCount = 2;
        this.studentDocumentInput = new StudentDocument("Наименование", "Номер");
    }
    ngOnInit() {
        this.getStudentDocument();
    }
    getStudentDocument() {
        this._studentDocumentService.getStudentDocument()
            .subscribe(value => this.studentDocumentOutput = value, error => this.errorMessage = error);
    }
    postStudentDocument(documentToPost) {
        console.log(JSON.stringify(documentToPost));
        this._studentDocumentService.postStudentDocument(JSON.stringify(documentToPost));
    }
};
DocumentsComponent = __decorate([
    core_1.Component({
        selector: 'my-documents',
        templateUrl: './app/content/documents/documents.component.html',
        providers: [documents_service_1.StudentDocumentService]
    }),
    __metadata("design:paramtypes", [documents_service_1.StudentDocumentService])
], DocumentsComponent);
exports.DocumentsComponent = DocumentsComponent;
class StudentDocument {
    constructor(name, number) {
        this.Name = name;
        this.Number = number;
    }
}
exports.StudentDocument = StudentDocument;
//# sourceMappingURL=documents.component.js.map