# Bulky Book

Bulky Book is an ASP.NET Core MVC application for managing categories with a SQL Server database backend.

![image (1)](https://github.com/RafayKhattak/BulkyBook-NET-MVC-Core/assets/90026724/af2be78f-cc16-464d-929e-42596054c465)

## Table of Contents
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [Project Structure](#project-structure)
- [Configuration](#configuration)
- [Features](#features)
- [Entity Framework](#entity-framework)
- [Usage](#usage)

## Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (Optional)

### Installation
1. Clone the repository: `git clone https://github.com/your-username/BulkyBookWeb.git`
2. Navigate to the project directory: `cd BulkyBookWeb`
3. Restore dependencies: `dotnet restore`
4. Update database: `dotnet ef database update`
5. Run the application: `dotnet run`

## Project Structure

- **BulkyBookWeb**
  - `Controllers`: Contains controllers handling HTTP requests.
  - `Data`: Defines the database context and migrations.
  - `Migrations`: Database migration files.
  - `Models`: Data models used in the application.
  - `Views`: Razor views for the application.
  - `wwwroot`: Static files (CSS, JavaScript, images).
  - `appsettings.json`: Configuration file for the application.
  - `Program.cs`: Entry point for the application.
  - `Startup.cs`: Configures services and middleware.

## Configuration

### AppSettings
The `appsettings.json` file contains configuration settings for the application.

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=Bulky;Trusted_Connection=True;"
  }
}
```

## Features
1. Create, Read, Update, and Delete (CRUD) operations for categories.
2. Display a list of categories with details.

## Entity Framework
This project uses Entity Framework Core for database operations. Entity Framework simplifies database interactions and allows for easy migrations.

## Usage
1. Launch the application.
2. Navigate to http://localhost:port-number in your web browser.

