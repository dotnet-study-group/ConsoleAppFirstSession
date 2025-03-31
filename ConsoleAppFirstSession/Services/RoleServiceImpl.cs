using ConsoleAppFirstSession.DbContext;

namespace ConsoleAppFirstSession.Services;

public class RoleServiceImpl : IRoleService
{
    private readonly FirstSessionContext _roleContext;
    
    public RoleServiceImpl(FirstSessionContext roleContext)
    {
        _roleContext = roleContext;
    }
    
    /*
    void IRoleService.Save(Role role)
    {
        try
        {
            _roleContext.Roles.Add(role);
            _roleContext.SaveChanges();
        }
        catch (Exception)
        {
            throw;
        }
    }

    void IRoleService.Delete(int id)
    {
        throw new NotImplementedException();
    }

    void IRoleService.Update(Role role)
    {
        throw new NotImplementedException();
    }

    List<Role> IRoleService.GetRoles()
    {
        throw new NotImplementedException();
    }
    */
}