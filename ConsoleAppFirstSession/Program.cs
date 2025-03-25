// See https://aka.ms/new-console-template for more information

using ConsoleAppFirstSession.DbContext;
using ConsoleAppFirstSession.Inputs;
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
services.AddScoped<IRoleService, RoleServiceImpl>();
services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var serviceProvider = services.BuildServiceProvider();

var roleService = serviceProvider.GetService<IRoleService>();
var userService = serviceProvider.GetService<IUserService>();

/*
var newRole = new Role
{
    Name = "Privado",
};
roleService.Save(newRole);
*/

var newUser = new UserInput
{
    Email = "input@gmail.com",
    UserName = "input",
    FirstName = "input",
    LastName = "input",
    Password = "inputPassword",
    RoleId = 6,
    Id = 3
};

try
{
    if (newUser.Id == 0)
    {
        userService!.Save(newUser);    
    }
    else
    {
        userService!.Update(newUser);
        //userService!.Delete(2);
    }
    
}
catch (Exception e)
{
    Console.WriteLine(e);
}


foreach (var user in userService?.GetUsers())
{
    Console.WriteLine(user);
}