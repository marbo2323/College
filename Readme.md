# Creting ASP.NET MVC webapp

[Microsoft Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-10.0&tabs=visual-studio-code)

## Check dotnet version

To check dotnet version use this command in terminal
```shell
dotnet --info
```

## Creating new MVC webapp

In this tutorial we create webapp in other domain as in Microsoft tutorial page. 

To create a new webapp use this commmand in terminal:
```shell
dotnet new mvc -o College
```

## Run the app

Trust dev SSL certificate by using this command in terminal:
```shell
dotnet dev-certs https --trust
```

Use key combination `Ctrl+F5` to run the app without debugging.

## Add Models

Add file Student.cs to Models folder

## Add NuGet Packages

Run the following .NET CLI commands:
```shell
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
```

Run app using `Ctrl+F5` to see if there are any problems on PROBLEMS tab.

## Scaffold pages

```shell
dotnet aspnet-codegenerator controller -name CoursesController -m Course -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
```

## Initial Migration

```shell
dotnet ef migrations add InitialCreate
```

[See in Tutorial what it does](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-10.0&tabs=visual-studio-code#initial-migration)


Update the database to the latest migration
```shell
dotnet ef database update
```








