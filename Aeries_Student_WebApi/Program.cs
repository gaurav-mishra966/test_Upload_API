
using Aeries_Student_WebApi.Data;
using Aeries_Student_WebApi.Repositories.Implementation;
using Aeries_Student_WebApi.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Adding CROS services to the application to communicate with UI components
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowAngularOrigin", policy =>
//    {
//        policy.WithOrigins("https://localhost:7272","*") // Allow requests from other application that needs to use this api
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactOrigin", policy =>
    {
        policy.WithOrigins("http://localhost:3000") // React app origin
              .AllowAnyHeader()  // Allow any headers
              .AllowAnyMethod() // Allow any HTTP method (GET, POST, etc.)
            .AllowAnyOrigin();
    });
});



// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


//Injecting AddDbContext with a type ApplicationDbContext
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AeriesConnectionString"));
});

//injecting repo and associated components
builder.Services.AddScoped<IMedicalRepository, MedicalRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllowReactOrigin");

app.UseRouting();

app.MapControllers();



app.Run();
