import { Component, OnInit } from '@angular/core';
import { DataSaverService } from '../services/data-saver.service';

@Component({
  selector: 'app-memory',
  templateUrl: './memory.component.html',
  styleUrls: ['./memory.component.scss']
})
export class MemoryComponent implements OnInit {

  dataSaver: DataSaverService;

  constructor(dataSaver: DataSaverService) 
  { 
    this.dataSaver = dataSaver;
  }

  ngOnInit(): void {
  }

}
