using JH_LAB1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IRouteRepository, RepositoryRoute>(); 
builder.Services.AddSingleton<ITruckRepository, RepositoryTruck>();
builder.Services.AddSingleton<IUserRepository, RepositoryUser>();
builder.Services.AddSingleton<ITruckWorkshopRepository, RepositoryTruckWorkshop>();

var app = builder.Build();

app.UseRouting(); //routing is a way to map a request to a specific controller and action
app.UseEndpoints(endpoints =>
        endpoints.MapDefaultControllerRoute()); //default route is the home controller and the index action


app.Run();