var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(
        int.Parse(Environment.GetEnvironmentVariable("PORT") ?? "8080")
    );
});

var app = builder.Build();

app.MapGet("/", () => "Hello from MSB Tech Solutions 🚀 Render is working!");
app.MapGet("/health", () => "OK");

app.Run();
