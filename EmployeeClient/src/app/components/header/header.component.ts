import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ExcelService } from '../../services/excel.service';
import { Employee } from '../../models/employee.model';
import { MatDialog } from '@angular/material/dialog';
import { AddemployeeComponent } from '../addEmployee/addemployee.component';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { DataService } from '../../store/data.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-header',
  standalone: true,
  imports: [CommonModule, FormsModule, ReactiveFormsModule, HeaderComponent],
  templateUrl: './header.component.html',
  styleUrl: './header.component.css'
})
export class HeaderComponent {

  searchText = this.fb.control('');

  constructor(private router:Router, private excelService:ExcelService, private readonly dataService: DataService, private fb: FormBuilder,  private dialog: MatDialog ) {}

  ngOnInit(): void {
    this.searchText.valueChanges.subscribe(value =>
      this.dataService.fiterEmployee(value)
    )
  }

  onAddEmployee() {
    this.dialog.open(AddemployeeComponent,{data :{},panelClass:'custom-dialog-container'
  },);
  }

  onExportToExcel() {
    this.dataService.employeeList.subscribe((employees: Employee[]) => {
      this.excelService.exportToExcel(employees, 'employees');
    });
  }

  filterEmployees() {
    this.dataService.fiterEmployee(this.searchText.value)
  }
  onLogOut() {
    sessionStorage.clear()
    this.router.navigate(['login'])
  }

}
