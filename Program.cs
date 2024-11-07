var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "WellCome here, this is your net place!");

app.MapPost("/login", (LoginDTO loginDTO) => 
{
    if (loginDTO.UserName == "" && loginDTO.Password == "")
        return Results.Ok("WellCome here");
    else
        return Results.Unauthorized();    
});

app.Run();



