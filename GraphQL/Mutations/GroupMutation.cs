using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;
using NAME_WIP_BACKEND.GraphQL.Inputs;


namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class GroupMutation
{
    public Group CreateGroup(AppDbContext context, GroupInput input)
    {
        var group = new Group
        {
            Name = input.Name,
            Desc = input.Desc
        };

        context.Groups.Add(group);
        context.SaveChanges();
        return group;
    }

    public Group? UpdateGroup(AppDbContext context, UpdateGroupInput input)
    {
        var group = context.Groups.Find(input.Id);
        if (group == null) return null;

        if (!string.IsNullOrEmpty(input.Name)) group.Name = input.Name;
        if (input.Desc != null) group.Desc = input.Desc;

        context.SaveChanges();
        return group;
    }

    public bool DeleteGroup(AppDbContext context, int id)
    {
        var group = context.Groups.Find(id);
        if (group == null) return false;
        context.Groups.Remove(group);
        context.SaveChanges();
        return true;
    }
}