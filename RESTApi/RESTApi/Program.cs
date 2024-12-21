using Microsoft.EntityFrameworkCore;
using RESTApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Registering the DbContext with dependency injection
builder.Services.AddDbContext<AdventureWorks2022DbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));  // Use the connection string defined in appsettings.json





// Add services to the container.
builder.Services.AddControllers();

// Add Swagger support for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "REST API v1"));

// Enable Swagger UI for testing the API
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Enable the API controllers to respond to requests
app.MapControllers();

app.Run();
