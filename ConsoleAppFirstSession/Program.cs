// See https://aka.ms/new-console-template for more information

using ConsoleAppFirstSession.DbContext;
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

var serviceProvider = services.BuildServiceProvider(); 

var _appDbContext = serviceProvider.GetService<FirstSessionContext>();
foreach (var user in _appDbContext.Users.ToList())
{
    Console.WriteLine(user.UserName);
    Console.WriteLine(user.Email);
    Console.WriteLine(user.Password);
}