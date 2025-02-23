# TaskManagementApp

## Overview

TaskManagementApp is a professional ASP.NET Core 7.0 project built on Onion Architecture principles. This project demonstrates clean coding practices, a modular design, and a clear separation of concerns. It leverages cutting-edge frameworks and patterns such as CQRS, Entity Framework Core, Fluent API, FluentValidation, MediatR, AutoMapper, and Bootstrap 5 to deliver a robust, scalable, and maintainable application.

## Key Features

- **Onion Architecture**: Separates domain, application, and infrastructure layers to promote a clean, testable, and maintainable codebase.
- **CQRS (Command Query Responsibility Segregation)**: Enhances performance and maintainability by isolating write operations (commands) from read operations (queries).
- **Entity Framework Core**: Utilizes a modern ORM for efficient data access and management.
- **Fluent API & FluentValidation**: Ensures data integrity and enforces business rules through robust validation.
- **MediatR**: Implements the mediator pattern to decouple in-process messaging and improve maintainability.
- **AutoMapper**: Simplifies complex object-to-object mappings, reducing repetitive mapping code.
- **Bootstrap 5**: Provides a responsive and modern user interface for a seamless user experience.

## Getting Started

### Prerequisites

- [.NET 7.0 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [PostgreSQL](https://www.postgresql.org/)
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or another preferred .NET development environment

### Installation

1. **Clone the repository:**
   ```bash
   git clone https://github.com/tanjubozok/TaskManagementApp.git
   ```

2. **Navigate to the project directory:**
   ```bash
   cd TaskManagementApp
   ```

3. **Restore the dependencies:**
   ```bash
   dotnet restore
   ```

### Database Configuration

1. Update the connection string in `appsettings.json` to match your database server settings.
2. Apply the Entity Framework Core migrations to create or update the database schema:
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
   By default, the application will be accessible at `https://localhost:5001`.

## Project Structure

- **Domain**: Contains the core business entities, domain models, and interfaces.
- **Application**: Implements business logic, handles commands and queries via CQRS, and includes AutoMapper profiles for object mapping.
- **Persistance**: Manages data access implementations and integrations with external services.
- **Web**: The ASP.NET Core web project that contains controllers, views, and the application entry point (`Program.cs`).

## AutoMapper Integration

AutoMapper is a key component in this project, used to streamline the mapping between domain models and DTOs/view models. AutoMapper profiles are configured within the Application layer, ensuring that object-to-object mappings are performed efficiently without cluttering the business logic with repetitive code.

## Contribution Guidelines

Contributions are highly appreciated! To contribute:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Submit a pull request with a detailed description of your changes.

## License

This project is licensed under the MIT License. For more information, please refer to the [LICENSE](LICENSE) file.

## Acknowledgments

This project is inspired by modern software architecture and design principles, emphasizing clean architecture and domain-driven design to ensure a scalable, maintainable, and testable codebase.

Happy Coding!
