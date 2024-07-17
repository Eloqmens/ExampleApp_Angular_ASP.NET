import { Component } from '@angular/core';
import { Client } from '../models/client';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'clients',
  templateUrl: './clients.component.html',
})

export class ClientsComponent {
  constructor(service: HttpClient) {
    service.get<Client[]>("Api/Client/GetAll")
    .subscribe(x => this.clients = x);
  }

  clients: Client[] = [];
}

