"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
Object.defineProperty(exports, "__esModule", { value: true });
const core_1 = require("@angular/core");
const platform_browser_1 = require("@angular/platform-browser");
const forms_1 = require("@angular/forms");
const router_1 = require("@angular/router");
const http_1 = require("@angular/http");
const devextreme_angular_1 = require("devextreme-angular");
const app_component_1 = require("./app.component");
const header_component_1 = require("./header/header.component");
const menu_component_1 = require("./header/menu/menu.component");
const footer_component_1 = require("./footer/footer.component");
const data_component_1 = require("./content/data/data.component");
const documents_component_1 = require("./content/documents/documents.component");
const claims_component_1 = require("./content/claims/claims.component");
let AppModule = class AppModule {
};
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            forms_1.FormsModule,
            devextreme_angular_1.DxButtonModule,
            devextreme_angular_1.DxFormModule,
            devextreme_angular_1.DxSelectBoxModule,
            http_1.HttpModule,
            devextreme_angular_1.DxDataGridModule,
            router_1.RouterModule.forRoot([
                { path: 'claims', component: claims_component_1.ClaimsComponent },
                { path: 'documents', component: documents_component_1.DocumentsComponent },
                { path: 'data', component: data_component_1.DataComponent },
                { path: '', redirectTo: '/data', pathMatch: 'full' }
            ])
        ],
        declarations: [
            app_component_1.AppComponent,
            header_component_1.HeaderComponent,
            menu_component_1.MenuComponent,
            footer_component_1.FooterComponent,
            data_component_1.DataComponent,
            documents_component_1.DocumentsComponent,
            claims_component_1.ClaimsComponent
        ],
        bootstrap: [app_component_1.AppComponent]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map