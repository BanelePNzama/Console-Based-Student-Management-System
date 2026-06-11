# 📚 Student Management System (Console App - C#)

## 📝 Overview
This is a C# console-based Student Management System built using a layered architecture. The application performs full CRUD operations (Create, Read, Update, Delete) on student records and integrates with SQL Server using Entity Framework 6 and stored procedures.

The project demonstrates real-world backend development principles such as separation of concerns, database integration, and input validation.

---

## ⚙️ Features
- ➕ Add new students
- 📄 View all students
- ✏️ Update student information
- ❌ Remove student records
- 🧾 Input validation and error handling
- 🗄️ SQL Server integration using stored procedures

---

## 🏗️ Architecture
The system follows a layered architecture:

- **Presentation Layer (View)**
  - Console-based user interface
- **Business Layer**
  - Input validation and business rules
- **Repository Layer**
  - Database communication logic
- **Data Layer**
  - Entity Framework DbContext + SQL Server

---

## 🛠️ Technologies Used
- C# (.NET Framework)
- Entity Framework 6
- SQL Server
- Stored Procedures
- ADO.NET (via EF execution)
- Console Application

---

## 📌 Key Learning Outcomes
- Built a full CRUD system using C# and SQL Server
- Worked with stored procedures and parameterized queries
- Applied layered architecture design principles
- Improved debugging and error-handling skills
- Implemented user input validation for data integrity

---

## 🚀 How to Run the Project
1. Clone this repository
2. Open the solution in Visual Studio
3. Restore NuGet packages (Entity Framework 6)
4. Update connection string in `App.config`
5. Run SQL scripts to create database and stored procedures
6. Build and run the application

---

## 🧑‍💻 Author
**Banele Nzama**

- Location: South Africa 🇿🇦

---

## ⭐ Project Purpose
This project was built as a learning exercise to strengthen backend development skills in C#, SQL Server, and layered software architecture.
