using TaskManagementApp.Application.Extensions;
using TaskManagementApp.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddPersistanceServices(builder.Configuration);
builder.Services.AddApplicationServices();




var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();
app.Run();