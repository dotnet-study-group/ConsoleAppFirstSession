using ConsoleAppFirstSession.Inputs;
using ConsoleAppFirstSession.Models;

namespace ConsoleAppFirstSession.Binders;

public static class UserBinder
{
    public static void Bind(this UserInput userInput, User user)
    {
        user.ModifiedDate = DateTime.Now;
        user.Email = userInput.Email;
        user.FirstName = userInput.FirstName;
        user.LastName = userInput.LastName;
        user.Password = userInput.Password;
        user.RoleId = userInput.RoleId;
    }
}