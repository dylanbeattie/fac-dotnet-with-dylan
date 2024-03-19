using System.Text;
using System.Text.Json;

Console.WriteLine("Welcome to the Todo Client!");
var http = new HttpClient();
while(true) {
    Console.WriteLine("Enter a TODO");
    var todo = Console.ReadLine();
    var json = JsonSerializer.Serialize(todo);
    var content = new StringContent(json, 
        Encoding.UTF8,
        "application/json");
    await http.PostAsync("https://db5ee1b9512a.ngrok.app/api/todos", content);
}
