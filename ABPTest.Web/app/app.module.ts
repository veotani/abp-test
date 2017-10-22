import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { RouterModule, Routes } from '@angular/router';
import { HttpModule } from '@angular/http';
import { DxFormModule, DxButtonModule, DxSelectBoxModule, DxDataGridModule } from 'devextreme-angular';


import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { MenuComponent } from './header/menu/menu.component';
import { FooterComponent } from './footer/footer.component';
import { DataComponent } from './content/data/data.component';
import { DocumentsComponent } from './content/documents/documents.component';
import { ClaimsComponent } from './content/claims/claims.component';

@NgModule({
    imports: [
        BrowserModule,
        FormsModule,
        DxButtonModule,
        DxFormModule,
        DxSelectBoxModule,
        HttpModule,
        DxDataGridModule, 
        RouterModule.forRoot([  
        { path: 'claims', component: ClaimsComponent },
        { path: 'documents', component: DocumentsComponent },
        { path: 'data', component: DataComponent },
        { path: '', redirectTo: '/data', pathMatch: 'full'}
    ])
    ],
    declarations: [
        AppComponent,
        HeaderComponent,
        MenuComponent,
        FooterComponent,
        DataComponent,
        DocumentsComponent,
        ClaimsComponent
    ],
    bootstrap: [ AppComponent ]
})
export class AppModule { }