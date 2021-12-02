using Microsoft.AspNetCore.Datasync;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AzureToDoAppApi.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ToDoAppContext>(options =>

    options.UseSqlServer(builder.Configuration.GetConnectionString("ToDoAppContext")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDatasyncControllers();
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

//app.UseAuthorization();

app.MapControllers();

app.Run();
