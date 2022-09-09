using asp_razor.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddDbContext<asp_razorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("asp_razorContext") ?? throw new InvalidOperationException("Connection string 'asp_razorContext' not found.")));

var app = builder.Build();

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
