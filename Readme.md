# Creating ASP.NET MVC webapp

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

## Add .gitignore

To add .gitignore to the project run command:
```shell
dotnet new gitignore
```

## Clean previos build results

```shell
dotnet clean
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

These commands will generate controllers and views for models to enable perform CRUD operations with given models.

```shell
# Courses
dotnet aspnet-codegenerator controller -name CoursesController -m Course -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

# Departments
dotnet aspnet-codegenerator controller -name DepartmentsController -m Department -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

# Instructors
dotnet aspnet-codegenerator controller -name InstructorsController -m Instructor -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

# Delinquents
dotnet aspnet-codegenerator controller -name DelinquentsController -m Delinquent -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

# Students
dotnet aspnet-codegenerator controller -name StudentsController -m Student -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite

# Enrollments
dotnet aspnet-codegenerator controller -name EnrollmentsController -m Enrollment -dc College.Data.CollegeContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries --databaseProvider sqlite
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

## Subsequential migrations

```shell
dotnet ef migrations add AddDelinquent
```

## Seeding Initial Data

[See Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-10.0&tabs=visual-studio#seed-the-database)








