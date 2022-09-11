# asp-razor

```bash
# New asp.net core project
dotnet new webapp -o ProjectName (I named it asp-razor)
dotnet dev-certs https --trust
```

The `Pages` folder contains `.cshtml` for markup and/or .`cshtml.cs` for event logic.  
Supporting files begin with an underscore. The wwwroot folder contains static assets.  
The EF Core is an O/RM which uses model classes to create the app's database.  

```ps1
# Install EFC tools
# Generates code for init db schema
# Name it anything, e.g.: "InitialCreate"
Add-Migration InitialCreate
Update-Database
```

`View` > `SQL Server Object Viewer`  
`SQL Server` > `(localdb)\MSSQLLocalDB` > `Databases` > `ProjectName.Data` > `Tables`  
See the `View Designer` of created model.

This project uses LocalDB, a lightweight version of SQL Server Express.  
Look for `*.mdf` files in the `C:\Users\<user>\` directory.

If `Update-Database` has not been run:

```error
SqlException: Cannot open database "RazorPagesMovieContext-" requested by the login. The login failed. Login failed for user 'user name'.
```
