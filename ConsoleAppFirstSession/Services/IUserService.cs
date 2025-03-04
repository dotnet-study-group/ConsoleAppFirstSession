using ConsoleAppFirstSession.Models;

namespace ConsoleAppFirstSession.Services;

public interface IUserService
{
    void Save(User user);
    void Delete(int id);
    void Update(User user);
    List<User> GetUsers();
    
    List<User> GetUsersByEmail(string email);
}