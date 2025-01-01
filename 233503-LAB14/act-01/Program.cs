using act_01; // Ensure this matches your actual namespace
using act_01.Data; // Ensure this matches your actual namespace
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Register your ServerService here
builder.Services.AddSingleton<ServerService>(); // Register the ServerService

// If you have a WeatherForecastService, keep it; otherwise, you can remove it
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseHttpsRedirection(); // Ensure HTTPS redirection is enabled
app.UseStaticFiles(); // Serve static files

app.UseRouting(); // Enable routing

app.MapBlazorHub(); // Map Blazor Hub
app.MapFallbackToPage("/_Host"); // Fallback to the _Host page

app.Run(); // Run the application