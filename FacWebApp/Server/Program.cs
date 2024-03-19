using Microsoft.AspNetCore.Mvc;

var todos = File.ReadAllLines("todos.txt").ToList();
var provider = new FacDemoListProvider(todos);
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

builder.Services.AddScoped<IProvideTodoLists>(
    (IServiceProvider _) => provider);

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();

// app.MapGet("/", () => "Hello World!");
app.MapGet("/time", () => DateTime.Now);
app.MapGet("/api/todos", () => todos);
app.MapPost("/api/todos", ([FromBody] string body) =>
{
    Console.WriteLine(body);
    todos.Add(body);
    return Results.Created();
});

app.Run();

public interface IProvideTodoLists
{
    public List<String> GetTodoList();
}

public class FacDemoListProvider : IProvideTodoLists
{
    private List<string> todos;

    public FacDemoListProvider(List<string> todos) {
        this.todos = todos;  
    }
    public List<string> GetTodoList() => todos;
}