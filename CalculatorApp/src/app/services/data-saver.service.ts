import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataSaverService {

  private savedEquations : string[] = [];

  saveEquation(eq: string): void
  {
    this.savedEquations.push(eq);
  }

  getEquations(): string[]
  {
    return this.savedEquations;
  }

  constructor() { }
}
