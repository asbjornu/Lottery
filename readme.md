# Lottery

An ASP.NET Core 6 Web API that simulates a wine lottery.

## Getting Started

The application requires .NET 6.0 SDK to be installed. Then it should be
possible to run the application with the following command:

```sh
dotnet run --project Lottery.Web
```

## Missing Features

Since this is a very quickly put together prototype of a wine lottery, there
are numerous features that are missing. Some of the most important ones are
described below.

### Database

The application uses two in-memory repositories for storing and retrieving
data. This should of course be replaced with a proper database so state is
preserved across application restarts.

When adding a database, it would be wise to add another project that separates
the database access logic from the web API project.

### Authentication

The application does not have any authentication. This should be added to
ensure that only authorized users can access the application.

### Purchasing

The application has no way of actually purchasing tickets. Although the current
method is named `PurchaseTicket()`, it does not actually invoke any purchasing
logic. A better name to describe the current implementation would be
`ReserveTicket()`, but `PurchaseTicket()` is used to match the future
implementation of the method.

### Drawing

The application has no way of actually drawing tickets for the lottery, which
makes it rather useless.

When adding the drawing logic, it would be wise to add a Core project to hold
all of the core domain logic of the application. The current classes in the
Web project would then serve as DTO classes only used by the API, with the
Core project containing the actual domain logic.

### User Interface

There is currently no proper user interface for the application. A Swagger UI is
provided for testing the API, but this is only for development and not for
actual use of the application.

### Tests

The application does not have any tests. This should naturally be added to
ensure that the application works as expected and continues to do so with future
changes.
