using asp_razor.Data;
using asp_razor.Models;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddDbContext<asp_razorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("asp_razorContext") ?? throw new InvalidOperationException("Connection string 'asp_razorContext' not found.")));

var app = builder.Build();

// Ensure context is disposed
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    // Pass database context instance: services
    SeedData.Initialize(services); // Seed the DB
}

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // See https://aka.ms/aspnetcore-hsts
    app.UseHsts();
}

// Redirect HTTP -> HTTPS
app.UseHttpsRedirection();
app.UseStaticFiles(); // Serve wwwroot

// Route matching middleware
app.UseRouting();

// Authorize secure user access
app.UseAuthorization();
// Configure routing endpoints
app.MapRazorPages();

app.Run();
