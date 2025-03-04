// See https://aka.ms/new-console-template for more information

using ConsoleAppFirstSession.DbContext;
using ConsoleAppFirstSession.Models;
using ConsoleAppFirstSession.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile($"appsettings.json", true, true);

IConfiguration config = builder.Build();

var services = new ServiceCollection();
services.AddDbContext<FirstSessionContext>(options => 
                                    options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

services.AddScoped<IUserService, UserServiceImpl>();

var serviceProvider = services.BuildServiceProvider(); 

var userService = serviceProvider.GetService<IUserService>();

/*
var newUser = new User
{
    Email = "prueba@gmail.com",
    UserName = "prueba",
    FirstName = "Prueba",
    LastName = "Prueba",
    Password = "pruebaPassword",
    Id = 2
};

try
{
    if (newUser.Id == 0)
    {
        userService!.Save(newUser);    
    }
    else
    {
        //userService!.Update(newUser);
        userService!.Delete(2);
    }
    
}
catch (Exception e)
{
    Console.WriteLine(e);
}
*/
foreach (var user in userService?.GetUsers())
{
    Console.WriteLine(user);
}