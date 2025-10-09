using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class UserRoleMutation
{
    public UserRole CreateUserRole(AppDbContext context, UserRoleInput input)
    {
        var role = new UserRole { RoleName = input.Name };
        context.UserRoles.Add(role);
        context.SaveChanges();
        return role;
    }

    public UserRole? UpdateUserRole(AppDbContext context, UpdateUserRoleInput input)
    {
        var role = context.UserRoles.Find(input.Id);
        if (role == null) return null;
        if (!string.IsNullOrEmpty(input.Name)) role.RoleName = input.Name;
        context.SaveChanges();
        return role;
    }

    public bool DeleteUserRole(AppDbContext context, int id)
    {
        var role = context.UserRoles.Find(id);
        if (role == null) return false;
        context.UserRoles.Remove(role);
        context.SaveChanges();
        return true;
    }
}