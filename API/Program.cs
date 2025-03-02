using API.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(options=>
{

var config =builder.Configuration;
var connectionString =config.GetConnectionString("defaultConnection");

options.UseSqlite(connectionString);

});

builder.Services.AddCors();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi ders 9 a kadar sıkıntısız çalıstı 
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/openapi/v1.json", "My API v1");
});

}

app.UseHttpsRedirection();
app.UseCors(opt=>

{
    opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"); //VİDEO 20dde yaptı
});

app.UseAuthorization();

app.MapControllers();

app.Run();
