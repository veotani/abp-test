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
const person_service_1 = require("./person.service");
require("rxjs/add/operator/map");
require("rxjs/Rx");
let DataComponent = class DataComponent {
    constructor(_personservice) {
        this._personservice = _personservice;
        this.labelLocation = "top";
        this.readOnly = true;
        this.showColon = true;
        this.minColWidth = 300;
        this.colCount = 2;
    }
    helloWorld() {
        alert('Hello world!');
    }
    ngOnInit() {
        this.getPerson();
    }
    getPerson() {
        this._personservice.getPerson()
            .subscribe(value => this.person = value, error => this.errorMessage = error);
    }
};
DataComponent = __decorate([
    core_1.Component({
        selector: 'my-data',
        templateUrl: './app/content/data/data.component.html',
        providers: [person_service_1.PersonService]
    }),
    __metadata("design:paramtypes", [person_service_1.PersonService])
], DataComponent);
exports.DataComponent = DataComponent;
class Person {
}
exports.Person = Person;
//# sourceMappingURL=data.component.js.map