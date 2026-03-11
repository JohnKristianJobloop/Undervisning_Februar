using System.Text;
using AspNetCoreIntro.Extensions;
using AspNetCoreIntro.Models.Dto;
using AspNetCoreIntro.Models.Entities;
using AspNetCoreIntro.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddTodoItemRepository();

builder.Services.AddControllers();


var app = builder.Build();

Console.WriteLine(app.Environment.EnvironmentName);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.MapControllers();


app.MapGet("/hello", () =>
{
    return "Hello World!";
});

app.MapGet("/verifyAge/{age:int}", (int age) =>
{
    if (age >= 18) return Results.Ok("You can drink at this establishment");
    else return Results.BadRequest("Not Allowed");
});


//TODO ITEM ENDPOINTS!

app.MapGet("/todoitems", (TodoItemRepository repository) => repository.Get());

app.MapGet("/todoitems/{id:guid}", (Guid id, TodoItemRepository repository) => repository.Get(id));

app.MapPost("/todoitems", ([FromBody]CreateTodoItemDto item, TodoItemRepository repository) =>
{
    try
    {
        var newItem = repository.AddItem(item);
        return Results.Created($"/todoitems/{newItem.Id}", newItem);
    } catch (ArgumentNullException ex)
    {
        return Results.BadRequest(ex.Message);
    }
});

app.MapDelete("/todoitem/{id:guid}", (Guid id, TodoItemRepository repository) => repository.Delete(id));

app.MapPut("/todoitem", ([FromBody]TodoItem item, TodoItemRepository repository) => Results.Created($"/todoitems/{item.Id}", repository.Put(item)));

app.UseStaticFiles();

app.Run();

