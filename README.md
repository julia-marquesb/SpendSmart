# SpendSmart

SpendSmart is a simple expense tracking application built with ASP.NET Core MVC. It allows users to add, edit, delete, and view expenses.

## Features
- View all recorded expenses
- Add new expenses with a description and value
- Edit existing expenses
- Delete expenses
- Display the total sum of expenses

## Technologies Used
- C#
- ASP.NET Core MVC
- Entity Framework Core
- Microsoft SQL Server

## Installation and Setup
1. Clone the repository:
   ```sh
   git clone https://github.com/yourusername/SpendSmart.git
   ```
2. Navigate to the project folder:
   ```sh
   cd SpendSmart
   ```
3. Install dependencies:
   ```sh
   dotnet restore
   ```
4. Update the database:
   ```sh
   dotnet ef database update
   ```
5. Run the application:
   ```sh
   dotnet run
   ```

## Usage
- Navigate to `http://localhost:` in your browser.
- Use the UI to add, edit, or delete expenses.
- The total sum of expenses is displayed on the Expenses page.
