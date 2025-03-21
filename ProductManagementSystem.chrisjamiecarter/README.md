<div align="center">
    <img src="./_resources/product-management-system-logo.png" alt="logo" width="100px" />
    <h1>Product Management System</h1>
</div>

Welcome to the **Product Management** System!

This is a .NET project designed to demonstrate role based authentication and authorisation with ASP.NET Core Identity.

Product Management System is a back-of-store application developed soley using .NET!
Users can create, view, update and delete products. Whilst admins can create, view, update and delete users. Owners have full controls, and account with no role will just be able to see the home page.

The web front-end is delivered by a Blazor Web App and utilises Boostrap for styling.
There is an integrated SQL Server database in the back-end.

## Requirements

This application fulfills the following [The C# Academy - Product Management System](https://thecsharpacademy.com/project/72/product-management-system) project requirements:

- [x] This is back-of-store app where users will manage products. Feel free to choose any industry
- [x] You can use any ASP.NET front-end solution (Razor Pages, MVC, Blazor)
- [x] You need to use ASP.NET Core Identity
- [x] Users should be able to add, delete, update and view products
- [x] Products should have at least the following products: IsActive, DateAdded, Price
- [x] You don't need to add relational data (i.e. product categories, orders)
- [x] The app needs to have an admin area that will only be accessible to users with the 'Admin' role
- [x] In the Admin area, admin staff will be able to add, update, delete and view staff
- [x] New staff should be able to register themselves. Registration should be confirmed by e-mail
- [x] Staff should be able to reset their password
- [x] Staff should be able to recover their forgotten password
- [x] You need to implement an e-mail service for account confirmation and password functionalities
- [x] You need to seed test data
- [x] You need to use EF's EnsureCreated method so the database and tables are created automatically
- [x] You need to add logging logic to your app and save logs to your database when errors occur

## Features

- **Blazor**:
  - The web front end has been built with Blazor Web App v9.
- **Bootstrap**:
  - The web UI is styled using Bootstrap v5.3.3.
- **Products**:
  - Users can create, view, update and delete products. Search, ordering and pagination has been implemented.
- **Users**:
  - Admins can create, view, update and delete users. Search, ordering and pagination has been implemented.
- **Account**:
  - New users can register themselves, or an Admin can create them. However, to log in they must first confirm their email. Authenticated users can update their email or set/change their password.
- **Email Integration**:
  - Email confirmations, change of emails, and password resets are all handled via a link send via email.
- **Error Logging**:
  - Any application errors are written to a database audit table.
- **Entity Framework Core**:
  - Entity Framework Core is used as the ORM.
- **SQL Server**:
  - SQL Server is used as the data provider.
- **Responsive Web Design**:
  - A user-friendly web interface has been designed to work on various devices.

## Technologies

- .NET
- Blazor
- Bootstrap
- HTML
- CSS
- ASP.NET Core Identity
- Entity Framework Core
- SQL Server

## Getting Started

**IMPORTANT NOTE**:

The `InitialCreate` database migration has been created.

On start-up of the **BlazorApp** application, any required database creation/migrations will be performed.

### Prerequisites

- .NET 9 SDK.
- An IDE (code editor) like Visual Studio or Visual Studio Code.
- A database management tool (optional).

### Installation

1. Clone the repository:

   - `git clone https://github.com/chrisjamiecarter/product-management-system.git`

2. Navigate to the Web project directory:

   - `cd src\ProductManagement.BlazorApp`

3. Configure the application:

   - Update any required settings in `appsettings.json` to target your environment:
     - ConnectionStrings
       - ProductManagement: Required to target database.
     - EmailOptions
       - SmtpHost: Your email client host.
       - SmtpPort: Your email client port.
       - SmtpUser: Your email client username.
       - SmtpPassword: Your email client password.
       - FromName: The display name that emails will be sent from.
       - FromEmailAddress: The email address that emails will be sent from.
     - Logging
       - LogLevel: Define any custom logging requirements.
     - SeederOptions:
       - SeedDatabase: Set to true to seed database, false will not seed database.
       - SeedUsers: Define Email and Role of users to be seeded.
       - NOTE: Generated passwords will be in the format: email before the @ symbol, upper case first, lower case rest, then 123###       - e.g. user@email.com = User123###

4. Build the application using the .NET CLI:

   - `dotnet build`

### Running the Application

1. You can run the `BlazorApp` application from Visual Studio.

NOTE: If you run from Visual Studio, the application may catch a `Microsoft.AspNetCore.Components.NavigationException` exception. Un-check `Break when this exception type is user-unhandled`

![YouTube Video Demonstration](./_resources/turn-this-off.png)

OR

1. Run the `BlazorApp` application using the .NET CLI in the Web project directory:

   - `cd src\ProductManagement.BlazorApp`
   - `dotnet run`

2. Navigate to `https://localhost:7128` on your choice of web browser.

## Usage

Please refer to the short YouTube video demonstration below:

[![YouTube Video Demonstration](./_resources/product-management-system-home.png)](https://www.youtube.com/watch?v=P36DjCTBLRI "Product Management System Showcase")

## How It Works

- **Web Project**: This project uses Blazor Web App v9 to serve .NET pages to your web browser. Interactive render mode provides interactability.
- **Web Design**: This project uses Bootstrap v5.3.3 to style the app and provide a responsive web design.
- **Authentication and Authorization**: This project uses ASP.NET Core Identity to secure the app.
- **MediatR**: MediatR is used to send and handle commands and queries within the application.
- **Seeding**: Bogus is used to generate fake product data for the database.
- **Logging**: Serilog and it's MsSqlServer Sink is used to write log messages to the database.
- **Data Storage**: A new SQL Server database is created and the required schema is set up at run-time, or an existing database is used if previously created.
- **Data Access**: Interaction with the database is via Entity Framework Core.

## Project Architecture

This project follows the **Clean Architecture** principles combined with the **Command Query Responsibility Segregation (CQRS)** pattern. By following these architectural patterns, the project remains modular, testable, and adaptable to future changes.

### Clean Architecture

The solution is structured to enforce separation of concerns, making the codebase more maintainable, scalable, and testable. It consists of four main distinct layers:

- Domain Layer: Contains the core business logic and domain entities, independent of external frameworks.
- Application Layer: Implements use cases and CQRS handlers, providing a clear separation between commands (modifications) and queries (retrieval).
- Infrastructure Layer: Handles external concerns such as database access, authentication, email and third-party integrations.
- Presentation Layer: Provides the user interface, built with Blazor, and interacts with the application layer via MediatR requests.

### CQRS

The CQRS pattern is applied to separate read and write operations. Commands handle data modifications, while queries retrieve data efficiently. This improves performance, scalability, and maintainability, especially when combined with Clean Architecture.

## Database

![entity relationship diagram](./_resources/entity-relationship-diagram.png)

## Version

This document applies to the ProductManagementSystem v1.0.0 release version.

---

**_Happy Product Managing!_**
