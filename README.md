# Restaurants API

## Overview

This project is a RESTful API for managing restaurant data. It leverages several modern technologies, libraries, frameworks, and design patterns to ensure scalability, maintainability, and performance.

## Architecture

### Clean Architecture

The project follows the principles of Clean Architecture to ensure a clear separation of concerns and maintainability. The main layers of the architecture are:

- **Domain Layer**: Contains the core business logic and domain entities. This layer is independent of any other layers and does not depend on any external libraries or frameworks.
- **Application Layer**: Contains the application logic, including commands, queries, and handlers. This layer depends on the domain layer but is independent of the infrastructure and presentation layers.
- **Infrastructure Layer**: Contains the implementation details for data access, external services, and other infrastructure concerns. This layer depends on the application and domain layers.
- **Presentation Layer**: Contains the API controllers and related logic. This layer depends on the application layer and is responsible for handling HTTP requests and responses.

By following Clean Architecture, the project ensures that the core business logic is isolated from external concerns, making it easier to test, maintain, and extend.

## Authentication & Authorization

The API uses the ASP.NET Core Identity package in conjunction with the use of JWT (JSON Web Tokens) and Cookies for authentication and authorization. This combination helps secure the API against various OWASP security risks by:

- **Ensuring Strong Authentication**: ASP.NET Core Identity provides robust mechanisms for user authentication, including password hashing and multi-factor authentication, reducing the risk of weak password attacks.
- **Preventing Cross-Site Scripting (XSS)**: ASP.NET Core Identity includes built-in protection against XSS attacks by encoding output and validating input.
- **Mitigating Cross-Site Request Forgery (CSRF)**: The framework includes anti-CSRF tokens to protect against CSRF attacks.
- **Managing User Permissions**: The use of roles and claims within JWTs ensures that only authorized users can access specific endpoints, enforcing proper access control.
- **Managing User Roles**: ASP.NET Core Identity allows for the creation and management of user roles, enabling fine-grained control over user permissions and access levels. This ensures that users have appropriate access based on their roles, further enhancing security.

By leveraging these features, the API is better protected against common security vulnerabilities identified by OWASP.

## Design Patterns

### CQRS (Command Query Responsibility Segregation)

The project follows the CQRS pattern to separate read and write operations. This helps in optimizing the performance and scalability of the application.

### Dependency Injection

ASP.NET Core's built-in Dependency Injection (DI) framework is used to manage dependencies, promoting loose coupling and easier testing.

### Repository Pattern

The Repository Pattern is used to abstract the data access logic, making the code more maintainable and testable.

## Technologies and Libraries

### ASP.NET Core

The API is built using ASP.NET Core, a cross-platform, high-performance framework for building modern, cloud-based, Internet-connected applications.

### MediatR

[MediatR](https://github.com/jbogard/MediatR) is used to implement the CORS (Cross-Origin Resource Sharing) policy. It helps in decoupling the request handling logic from the controllers, promoting a clean architecture.

### Serilog

[Serilog](https://serilog.net/) is used for logging. It provides a simple and efficient way to log messages to various outputs, including console, files, and Application Insights.

### AutoMapper

[AutoMapper](https://automapper.org/) is used to map domain entities to Data Transfer Objects (DTOs). DTOs are used to transfer data between layers, ensuring that the domain entities are not exposed directly to the presentation layer. This simplifies the process of converting complex objects into simpler representations and helps in maintaining a clear separation of concerns.

### FluentValidation

[FluentValidation](https://fluentvalidation.net/) is used for validating incoming requests. It provides a fluent interface for building strongly-typed validation rules.

### FluentAssertions

[FluentAssertions](https://fluentassertions.com/) is used for writing unit tests. It provides a set of extension methods for asserting the expected outcomes of tests in a more readable and maintainable way.

### Mocking

[MoQ](https://github.com/moq/moq4) is used for creating mock objects in unit tests. It helps in isolating the code under test by simulating the behavior of dependencies.

### Entity Framework Core

[Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) is used as the Object-Relational Mapper (ORM) for data access. It simplifies the process of interacting with the database by allowing developers to work with domain-specific objects rather than database tables and SQL queries. DTOs are used in conjunction with Entity Framework to ensure that only the necessary data is retrieved and sent to the client, improving performance and security.

## CI/CD and Deployment to Azure

The API is deployed to Azure, leveraging Azure App Services for hosting and Azure Blob Storage for storing data. Continuous Integration and Continuous Deployment (CI/CD) pipelines are set up using GitHub Actions to automate the deployment process.
