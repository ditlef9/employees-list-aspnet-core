![Employees List ASP.NET Core](docs/employees-list-aspnet-core-logo.png)

ASP.NET Core with Razor Views!



CRUD operations:
* List employee
* Add employee
* Edit employee
* Delete employee

Uses SQL Server database with Entity Framework Core with the following tables:
* Countries
* Persons


## Index

[🏠 1 Howto run locally](#-1-howto-run-locally)<br>
[☁️ 2 Howto deploy to Azure](#%EF%B8%8F-2-howto-deploy-to-azure)<br>
[🛠️ 3 How I created the application](#%EF%B8%8F-3-how-i-created-the-application)<br>
[➡️ 4 Database](#-4-database)<br>
[📜 5 License](#-5-license)<br>


## 🏠 1 Howto run locally

1. Install Visual Studio Community: https://visualstudio.microsoft.com
2. In Visual Studio Code Install Workloads: `ASP.Net and Web Development`

Clone the repository and open it in Visual Studio Community.

**Set font size**<br>
I like to increase the font size from 10 to 11.

Tools > Options > Enviroment: Fonts and Colors<br>

* Size: 11

**Start the app:**<br>
```
dotnet watch run --launch-profile https
```

--- 

## ☁️ 2 Howto deploy to Azure

--- 

## 🛠️ 3 How I created the application

Visual Studio > New Project > Language: C# > Project Types: Web > `ASP.NET Core Empty`


**Adding views to a controller function**<br>
For each controller i went to the function example `public IActionResult Index()`, right clicked
and selected add `Razor View - Empty`.

**Creating Entities, Controllers and Services**<br>
Country and Person is created as Entities<br>
Next I added controllers for Person named `PersonsController.cs`.

I then added services for `CountriesService.cs` and `PersonsService.cs`.

**Adding Views**<br>
The views are located under `Views` directory. Persons-views are the 
important views. 


**Database with SQL Server**<br>

I installed drivers for SQL Server:<br>

`dotnet add package Microsoft.EntityFrameworkCore.SqlServer`

The DB Sets are located in the file
`Entities\PersonsDbContext.cs`.


--- 

## ➡️ 4 Key Differences Between ASP.NET MVC and ASP.NET Core  

🏛️ ASP.NET MVC is a framework built on the .NET Framework and works only on Windows. 
It uses a monolithic architecture, relies on IIS for hosting, 
and offers limited support for dependency injection. 
Development is primarily done in Visual Studio, and the framework is no longer actively updated or supported, 
making it less suitable for modern web applications.  

🌐 ASP.NET Core, on the other hand, is a cross-platform, high-performance framework built on .NET Core. 
It features a modular architecture, supports multiple hosting options like Kestrel and IIS, 
and includes built-in dependency injection. ASP.NET Core supports development on various IDEs, 
such as Visual Studio Code, and is actively maintained with regular updates, 
making it ideal for modern and cloud-based apps.  

--- 

## 📜 5 License

This project is licensed under the
[Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

```
Copyright 2024 github.com/ditlef9

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```

