# LibraryManagementSystem

## Overview
A Windows Forms application developed using C# and SQL Server for managing library operations.

## Features
Admin :
  - Add Books/Students
  - Update Books/Students
  - Delete Books/Students
  - Search Books/Students
  - Edit Books/Students Details
  - Issue Books
  - Return Books

Students:
  - Singin/Login
  - Issue Books
  - Return Books
  - Edit Your Details


## AI Chatbot for Students :

  AI Chatbot for Students is an intelligent desktop to create for students help to manage your book shelve.
  
  The goal of this project is to help students learn more effectively by providing quick access to information, explanations, and academic       assistance.
  
  Features
  Student-friendly conversational interface
  Answers academic questions instantly
  Student can Issue Book, Return Book and category wise suggested Books
  Simple and interactive user experience
  Real-time response generation
  Easy-to-use interface 
      
## Technologies Used
- C#
- Windows Forms
- SQL Server
- ADO.NET
- Visual Studio

## Project Structure


LibraryManagementSysterm/
```
├── Program.cs              # Application entry point
├── Admin/                  # Admin forms (books, students, issue/return)
├── Students/               # Student forms (login, registration, books)
├── Common/                 # Shared forms (splash, main menu, help)
├── Chatbot/                # AI chatbot for students
├── Data/                   # Database access and typed datasets
├── Properties/             # App settings and resources
└── Resources/                # Images and assets
```

## How to Run
1. Clone repository
2. Open solution in Visual Studio
3. Configure database connection
4. Run project

## Future Enhancements
- Fine Calculation
- Role-Based Authentication

## Database
1. Open SSMS.
2. Connect to SQL Server.
3. Open Database/Library.sql.
4. Press F5 (Execute).
5. Database and tables are created automatically.
6. Run your C# application.

## NOTE :
  -Set you Api_key and Connection_String in App.Config file 
  -If run application and quality are low show then you go to bin/debug your .exe application properties and change High DPI setting
