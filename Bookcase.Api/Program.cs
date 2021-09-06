var builder = WebApplication.CreateBuilder(args);

// Add any services
builder.Services.AddCors();

var app = builder.Build();

// Anything after build is the callback

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseCors(cfg => 
{
 if (app.Environment.IsDevelopment())
    {
        cfg.AllowAnyOrigin();
        cfg.AllowAnyMethod();
        cfg.AllowAnyHeader();
    }
});

app.MapGet("/shelf", () => new[] { "OL64468W", "OL103134W" });

app.Run();


