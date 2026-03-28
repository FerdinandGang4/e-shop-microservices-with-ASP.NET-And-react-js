var builder = WebApplication.CreateBuilder(args);

//add services using dependency injection

var app = builder.Build();

//Configure http request pipelines

app.Run();
