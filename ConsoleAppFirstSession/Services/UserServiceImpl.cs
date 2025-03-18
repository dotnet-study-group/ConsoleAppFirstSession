using ConsoleAppFirstSession.DbContext;
using ConsoleAppFirstSession.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppFirstSession.Services;

public class UserServiceImpl : IUserService
{
    private readonly FirstSessionContext _userContext;
    
    public UserServiceImpl(FirstSessionContext userContext)
    {
        _userContext = userContext;
    }
    public void Save(User user)
    {
        try
        {
            user.CreatedDate = DateTime.Now;
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(User user)
    {
        try
        {
            var userToUpdate = _userContext.Users.Find(user.Id);
            if (userToUpdate != null)
            {
                userToUpdate.ModifiedDate = DateTime.Now;
                
                _userContext.Users.Update(userToUpdate);
                _userContext.SaveChanges();
            }
            else
            {
                throw new Exception("User not found");
            }
        }
        catch (Exception)
        {
            throw;
        }
    }

    public List<User> GetUsers()
    {
        return _userContext.Users.Include("Role").ToList();
    }

    public List<User> GetUsersByEmail(string email)
    {
        return _userContext.Users.Where(u => u.Email == email).ToList();
    }

    public void Delete(int id)
    {
        try
        {
            User userToDelete = _userContext.Users.Find(id);
            if (userToDelete != null)
            {
                _userContext.Users.Remove(userToDelete);   
                _userContext.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}