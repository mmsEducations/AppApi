var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


var app = builder.Build();

app.MapControllers(); //Controller tetiklenmesini sa�lar

app.Run();
