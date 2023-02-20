using Microsoft.EntityFrameworkCore;
using ProjectFeedbackApi.Controllers;
using ProjectFeedbackApi.Models;
using System.Data.Common;
using System.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddDbContext<ProjectFeedbackContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProjectFeedback")));

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
