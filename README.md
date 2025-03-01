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
[🛢 2 Database migration](#-2-Database migration)<br>
[☁️ 2 Howto deploy to Azure](#%EF%B8%8F-2-howto-deploy-to-azure)<br>
[🛠️ 3 How I created the application](#%EF%B8%8F-3-how-i-created-the-application)<br>
[📜 4 License](#-4-license)<br>


## 🏠 1 Howto run locally

1. Install Visual Studio Community: https://visualstudio.microsoft.com
2. In Visual Studio Code Install Workloads: `ASP.Net and Web Development`
3. Microsoft SQL Server Developer - https://www.microsoft.com/en-us/sql-server/sql-server-downloads
4. Azure Data Studio - https://learn.microsoft.com/en-us/azure-data-studio/download-azure-data-studio?view=sql-server-ver16&tabs=win-install%2Cwin-user-install%2Credhat-install%2Cwindows-uninstall%2Credhat-uninstall

Clone the repository and open it in Visual Studio Community.

**Set font size**<br>
I like to increase the font size from 10 to 11.

Tools > Options > Enviroment: Fonts and Colors<br>

* Size: 11

**Create database**<br>
Azure Data Studio > Localhost >  Datanases > `New Database`.

* Name: EmployeesList

The connections string is located in `appsettings.json` as the variable `DefaultConnection`.

**Start the app:**<br>
```
dotnet watch run --launch-profile https
```

---

## 🛢 2 Database migration

Database is created in [🏠 1 Howto run locally](#-1-howto-run-locally)

Tables are created in:<br>
* 


Database insertion is happening in<br>
* `Entities\PersonsDbContext.cs`



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

## 📜 4 License

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

