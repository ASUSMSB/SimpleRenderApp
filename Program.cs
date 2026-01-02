var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Render uses PORT env variable
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");

app.MapGet("/", () =>
{
    return "Hello from MSB Tech Solutions 🚀 Render is working!";
});

app.Run();
