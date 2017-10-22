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
const claims_service_1 = require("./claims.service");
require("rxjs/add/operator/map");
require("rxjs/Rx");
let ClaimsComponent = class ClaimsComponent {
    constructor(_claimsService) {
        this._claimsService = _claimsService;
        this.availableCategories = ["a", "b", "c", "d", "e"];
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
    addCategoryToArray(category) {
        if (!((this.categories.some(x => x == category)) ||
            (this.categories.some(x => x == "a") && (category == "c")) ||
            (this.categories.some(x => x == "c") && (category == "a")) ||
            (this.categories.length >= 3))) {
            this.categories.push(category);
        }
    }
};
ClaimsComponent = __decorate([
    core_1.Component({
        selector: 'my-claims',
        templateUrl: './app/content/claims/claims.component.html',
        providers: [claims_service_1.ClaimsService]
    }),
    __metadata("design:paramtypes", [claims_service_1.ClaimsService])
], ClaimsComponent);
exports.ClaimsComponent = ClaimsComponent;
class Claim {
    constructor(stringData) {
        this.StringData = stringData;
    }
}
exports.Claim = Claim;
//# sourceMappingURL=claims.component.js.map