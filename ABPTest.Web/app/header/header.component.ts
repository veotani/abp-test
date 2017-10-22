import {Component} from '@angular/core';

@Component({
    selector: 'my-header',
    templateUrl: 'app/header/header.component.html' 
})
export class HeaderComponent {
    myVar: string = 'MyVar'
}