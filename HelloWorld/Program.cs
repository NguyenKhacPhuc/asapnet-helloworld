var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/hello", () => "PhucNK1 Reached here");

app.Run();
