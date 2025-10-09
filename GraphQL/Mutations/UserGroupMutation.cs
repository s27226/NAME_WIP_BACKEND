using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class UserGroupMutation
{
    public UserGroup CreateUserGroup(AppDbContext context, UserGroupInput input)
    {
        var ug = new UserGroup { UserId = input.UserId, GroupId = input.GroupId };
        context.UserGroups.Add(ug);
        context.SaveChanges();
        return ug;
    }

    public UserGroup? UpdateUserGroup(AppDbContext context, UpdateUserGroupInput input)
    {
        var ug = context.UserGroups.Find(input.Id);
        if (ug == null) return null;
        if (input.UserId.HasValue) ug.UserId = input.UserId.Value;
        if (input.GroupId.HasValue) ug.GroupId = input.GroupId.Value;
        context.SaveChanges();
        return ug;
    }

    public bool DeleteUserGroup(AppDbContext context, int id)
    {
        var ug = context.UserGroups.Find(id);
        if (ug == null) return false;
        context.UserGroups.Remove(ug);
        context.SaveChanges();
        return true;
    }
}