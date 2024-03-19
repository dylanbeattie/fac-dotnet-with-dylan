using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
var todos = new List<string>() {
    "Learn .NET",
    "Birthday drinks",
    "Eat rice cakes"
};

app.MapGet("/", () => "Hello World!");
app.MapGet("/time", () => DateTime.Now);
app.MapGet("/todos", () => todos);
app.MapPost("/todos", ([FromBody]string body) => {
    Console.WriteLine(body);
    todos.Add(body);
    return Results.Created();
});

app.Run();

