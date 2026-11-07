var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Ok(new { 
    status = "Running", 
    service = "GMS Backend API", 
    time = DateTime.UtcNow 
}));

app.MapGet("/ping", () => "Pong from Backend!");

app.Run(); 