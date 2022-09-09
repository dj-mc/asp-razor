# asp-razor

```bash
# New asp.net core project
dotnet new webapp -o asp-razor
dotnet dev-certs https --trust
```

The `Pages` folder contains .cshtml for markup and/or .cshtml.cs for event logic.  
Supporting files begin with an underscore. The wwwroot folder contains static assets.  
The EF Core is an O/RM which uses model classes to create the app's database.  

```ps1
# Install EFC tools
# Generates code for init db schema
# Name it anything, e.g.: "InitialCreate"
Add-Migration InitialCreate
Update-Database
```
