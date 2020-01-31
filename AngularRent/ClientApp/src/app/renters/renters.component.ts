import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-renters',
  templateUrl: './renters.component.html'
})
export class RentersComponent {
  public renters: Renter[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Renter[]>('http://server:8078/api/Renters').subscribe(result => {
      this.renters = result;
      console.log(this.renters);
    }, error => console.error(error));
  }
}

interface Renter {
  RenterName: string;
  Contract: string;
  StartDate: string;
  EndDate: string;
  ContactPerson: string;
  ContactPhone: string;
  Annotation: string;
}
