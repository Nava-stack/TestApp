# 🥋Test Event Management System

Test C# Windows Forms Application  — built using **OOP principles**, **SQL Server**, and **WinForms** UI controls.

---

## ✨ Features

- ✅ Event Management with advanced controls (DateTimePicker, CheckBox, NumericUpDown, ComboBox)
- ✅ Reusable `Com` class for SQL operations
- ✅ Clean separation using Models, Forms, and Helpers
- ✅ Dashboard with panel-based navigation
- ✅ SQL Server integration using local DB

---

## 📂 Project Structure
├── Forms/ # UI Forms (EventForm, etc.)
├── Models/ # Business logic classes (EventClass.cs)
├── Helpers/ # Common logic (Com.cs, Database.cs)
└──  Program.cs

---

## 🛠️ Tools Used

| Tool            | Purpose                              |
|-----------------|--------------------------------------|
| C# WinForms     | Desktop UI Framework                 |
| SQL Server      | Relational database (SSMS used)      |
| Visual Studio   | Main development IDE                 |
| .NET Framework  | Target runtime                       |

---

## 🧠 Concepts Covered

- Object-Oriented Programming (Encapsulation, Abstraction)
- CRUD operations with SSMS backend
- WinForms controls: `TextBox`, `ComboBox`, `CheckBox`, `NumericUpDown`, `DataGridView`, `DateTimePicker`
- Reusable helper classes for database operations
- Data binding with DataTable and ComboBox (foreign keys)

---

## 🔧 How to Set Up

1. **Clone the repo:**

   ```bash
   git clone https://github.com/Nava-stack/TestApp.git

2. **Set up the Database:**

Open KickBlastJudo_DB.sql in SSMS.

Run the script to create the database and seed the data.

Update the connection string:

Navigate to Helpers/Database.cs.

Replace Data Source= with your SQL Server instance name.

Build & Run:

Open the .sln file in Visual Studio.

Press F5 to build and launch the app.
