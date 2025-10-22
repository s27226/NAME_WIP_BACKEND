using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class UserChatMutation
{
    public UserChat CreateUserChat(AppDbContext context, UserChatInput input)
    {
        var uc = new UserChat { UserId = input.UserId, ChatId = input.ChatId };
        context.UserChats.Add(uc);
        context.SaveChanges();
        return uc;
    }

    public UserChat? UpdateUserChat(AppDbContext context, UpdateUserChatInput input)
    {
        var uc = context.UserChats.Find(input.Id);
        if (uc == null) return null;
        if (input.UserId.HasValue) uc.UserId = input.UserId.Value;
        if (input.ChatId.HasValue) uc.ChatId = input.ChatId.Value;
        context.SaveChanges();
        return uc;
    }

    public bool DeleteUserChat(AppDbContext context, int id)
    {
        var uc = context.UserChats.Find(id);
        if (uc == null) return false;
        context.UserChats.Remove(uc);
        context.SaveChanges();
        return true;
    }
}