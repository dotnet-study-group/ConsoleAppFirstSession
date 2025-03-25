using AutoMapper;
using ConsoleAppFirstSession.DbContext;
using ConsoleAppFirstSession.Inputs;
using ConsoleAppFirstSession.Models;
using ConsoleAppFirstSession.Profiles;
using Microsoft.EntityFrameworkCore;
using ConsoleAppFirstSession.Binders;

namespace ConsoleAppFirstSession.Services;

public class UserServiceImpl : IUserService
{
    private readonly FirstSessionContext _userContext;
    private readonly IMapper mapper;
    private readonly MapperConfiguration configuration;
    
    public UserServiceImpl(IMapper mapper, FirstSessionContext userContext)
    {
        _userContext = userContext;
        this.mapper = mapper;
        configuration = new(cfg => {
            cfg.AddProfile<UserProfile>();
        });
    }
    public void Save(UserInput userInput)
    {
        try
        {
            User user = mapper.Map<User>(userInput);
            
            user.CreatedDate = DateTime.Now;
            
            _userContext.Users.Add(user);
            _userContext.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void Update(UserInput userInput)
    {
        try
        {
            var userToUpdate = _userContext.Users.Find(userInput.Id);
            if (userToUpdate != null)
            {
                userInput.Bind(userToUpdate);
                
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
            User userToDelete = _userContext?.Users.Find(id);
            if (userToDelete != null)
            {
                _userContext?.Users.Remove(userToDelete);   
                _userContext?.SaveChanges();
            }
        }
        catch (Exception)
        {
            throw;
        }
    }
}