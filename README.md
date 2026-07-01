# Employee Management System with Dashboard & RDLC Reports

An ASP.NET MVC 5 web application for managing employees and departments. The project demonstrates CRUD operations, Entity Framework (Database First), SQL Server integration, dashboard analytics, search functionality, and RDLC reporting.

---

## Features

- Employee Management
  - Create Employee
  - View Employee Details
  - Edit Employee
  - Delete Employee

- Department Management
  - Create Department
  - View Department Details
  - Edit Department
  - Delete Department

- Dashboard
  - Total Employees
  - Total Departments
  - Male Employees Count
  - Female Employees Count

- Search Employees
  - Search employees by name

- RDLC Reports
  - Employee Report
  - Displays employee information with department details

- Responsive UI
  - Bootstrap-based clean and modern interface

---

## Technologies Used

- ASP.NET MVC 5
- C#
- Entity Framework (Database First)
- SQL Server
- Bootstrap
- HTML5
- CSS3
- JavaScript
- RDLC Reports
- Microsoft Report Viewer

---

## Project Structure

```
EmployeeManagementSystem_Reports
│
├── Controllers
├── Models
├── Views
├── Reports
│   └── EmployeeReport.rdlc
├── Scripts
├── Content
└── App_Data
```

---

## Screens Included

- Dashboard
- Employee List
- Create Employee
- Edit Employee
- Employee Details
- Delete Employee
- Department Management
- Employee RDLC Report

---

## Database

This project uses SQL Server with Entity Framework Database First.

Tables:

- Employees
- Departments

Relationship:

```
Department (1)
      │
      │
      ▼
Employees (Many)
```

---

## How to Run

### Clone the repository

```bash
git clone https://github.com/Arpit-tR/EmployeeManagementSystem_Reports.git
```

### Open in Visual Studio

Open:

```
EmployeeManagementSystem_Reports.sln
```

### Restore NuGet Packages

```
Tools
→ NuGet Package Manager
→ Restore Packages
```

### Configure Database

Update the connection string in:

```
Web.config
```

Point it to your SQL Server instance.

### Run

Press

```
F5
```

or

```
Ctrl + F5
```

---

## Project Highlights

✔ ASP.NET MVC Architecture

✔ Entity Framework Database First

✔ SQL Server Integration

✔ CRUD Operations

✔ Dashboard Analytics

✔ Search Functionality

✔ RDLC Report Generation

✔ Bootstrap Responsive UI

---

## Future Enhancements

- Crystal Reports Integration
- Authentication & Authorization
- Role-based Access Control
- Export Reports to PDF/Excel
- Pagination
- Advanced Filtering
- Email Notifications

---

## Author

**Arpit Sadhukhan**

GitHub:
https://github.com/Arpit-tR

---

## License

This project is created for learning and demonstration purposes.
