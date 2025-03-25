using ConsoleAppFirstSession.Inputs;
using ConsoleAppFirstSession.Models;

namespace ConsoleAppFirstSession.Services;

public interface IUserService
{
    void Save(UserInput user);
    void Delete(int id);
    void Update(UserInput user);
    List<User> GetUsers();
    
    List<User> GetUsersByEmail(string email);
}