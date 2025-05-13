using System.Net.NetworkInformation;
using AuthAPI.application.repository_interfaces;
using AuthAPI.application.use_cases;
using AuthAPI.infrastructure.db;
using AuthAPI.interfaces.routes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<IUserRepository, InMemoryUserRepository>();

builder.Services.AddScoped<RegisterUser>();
builder.Services.AddScoped<GetUserProfile>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

UserRoutes.Route(app);

app.Run();
