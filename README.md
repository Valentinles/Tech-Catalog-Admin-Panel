# TechCatalog Admin Panel
**TechCatalog Admin Panel** is ASP.NET Core supportive web application for TechCatalog which provides full access to TechCatalog's database.

<img src="https://i.postimg.cc/ryvDq3FG/Screenshot-4.png" width="285"/> <img src="https://i.postimg.cc/28hVyGVs/Screenshot-5.png" width="285"/> <img src="https://i.postimg.cc/y8TxXNhn/Screenshot-6.png" width="285"/> <img src="https://i.postimg.cc/XYWXC55p/Screenshot-7.png" width="285"/>
## Getting Started

###### To run the application you need:
- .NET Core 3.1

- If you don't have *Sql server* on your machine you should replace the configuration in *TechCatalogAdminPanel.Web/appsettings.json* with this code:
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\mssqllocaldb;Database=TechCatalog;Trusted_Connection=True;MultipleActiveResultSets=true"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Warning"
    }
  },
  "AllowedHosts": "*"
}
```
- In your *package manger console* type: 

```
update-database
```

## Used technologies
- C#
- .NET Core 3.1
- .NET Core MVC
- Entity Framework Core
- Bootstrap 
- HTML
- CSS
