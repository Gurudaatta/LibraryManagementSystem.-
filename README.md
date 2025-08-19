# 📚 Library Management System

A simple desktop-based Library Management System built using C# and Windows Forms. This project helps manage books, members, and transactions in a library.

---

## 🚀 Features

- Admin login system
- Dashboard for managing books, members, and transactions
- Issue and return book functionality
- In-memory data storage (can be extended to SQL database)

---

## 🛠️ Technologies Used

- C#
- Windows Forms
- .NET Framework
- Visual Studio

---

## 📂 Project Structure

LibraryManagementSystem/
│
├── Forms/
│   ├── BookForm.cs
│   ├── MemberForm.cs
│   ├── IssueReturnForm.cs
│
├── Database/
│   ├── schema.sql
│
├── Program.cs
├── App.config
├── README.md

## 🧑‍💻 How to Run
1. Clone the repo:  
   `git clone https://github.com/yourusername/LibraryManagementSystem.git`

2. Open the project in Visual Studio:  
   File → Open → Project/Solution → Select the `.sln` file

3. Restore NuGet packages (if needed)

4. Set up the SQL Server database:  
   Open `schema.sql` in SSMS and execute it

5. Update the connection string in `App.config`:  
   Replace with your SQL Server details

6. Run the project:  
   Press `F5` or click `Start` in Visual Studio
