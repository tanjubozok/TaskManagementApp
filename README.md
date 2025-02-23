# TaskManagementApp

## Description

TaskManagementApp is an ASP.NET Core 7.0 test project developed using the Onion Architecture. This project aims to demonstrate clean code principles, modular design, and separation of concerns. It incorporates various technologies and methodologies such as CQRS, EF Core, Fluent API, FluentValidation, MediatR, and Bootstrap 5.

## Features

- **Onion Architecture**: Ensures a clean separation of concerns.
- **CQRS (Command Query Responsibility Segregation)**: Separates read and write operations to optimize performance.
- **Entity Framework Core**: Used for data access.
- **Fluent API & FluentValidation**: Ensures data integrity and validation.
- **MediatR**: Facilitates the implementation of the mediator pattern.
- **Bootstrap 5**: Provides a responsive design framework.

## Technologies Used

- **ASP.NET Core 7.0**
- **Entity Framework Core**
- **MediatR**
- **FluentValidation**
- **Bootstrap 5**

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/tanjubozok/TaskManagementApp.git
   ```
2. Navigate to the project directory:
   ```bash
   cd TaskManagementApp
   ```
3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

### Database Setup

1. Update the connection string in `appsettings.json` to point to your SQL Server instance.
2. Apply the migrations to create the database schema:
   ```bash
   dotnet ef database update
   ```

### Running the Application

1. Build the application:
   ```bash
   dotnet build
   ```
2. Run the application:
   ```bash
   dotnet run
   ```

The application should now be running on `https://localhost:5001`.

## Project Structure

- **Domain**: Contains the core entities and interfaces.
- **Application**: Contains the business logic, including CQRS handlers, validators, and services.
- **Infrastructure**: Contains data access implementations and external service integrations.
- **Web**: Contains the ASP.NET Core web application, including controllers and views.

## Contributing

Contributions are welcome! Please fork the repository and create a pull request with your changes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgments

- Inspired by the principles of clean architecture and domain-driven design.
