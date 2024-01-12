using DataMastersAPI.Repository;
using DataMastersAPI.Repository.Interface;
using DataMastersAPI.Service;
using DataMastersAPI.Service.Interface;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using DataMastersAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add scopes for newly created Services & Repositories
builder.Services.AddScoped<IEventService, EventService>();
builder.Services.AddScoped<IEventRepository, EventRepository>();

builder.Services.AddDbContext<DataMastersDbContext>(options =>
	options.UseSqlServer("Server=data-masters.database.windows.net;Database=data-masters;User=datamasteradmin;Password=Pass@1234;Encrypt=false"),
	ServiceLifetime.Scoped);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
