using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class SharedFileMutation
{
    public SharedFile CreateSharedFile(AppDbContext context, SharedFileInput input)
    {
        var file = new SharedFile
        {
            ChatId = input.ChatId,
            Link = input.Link,
            
        };
        context.SharedFiles.Add(file);
        context.SaveChanges();
        return file;
    }

    public SharedFile? UpdateSharedFile(AppDbContext context, UpdateSharedFileInput input)
    {
        var file = context.SharedFiles.Find(input.Id);
        if (file == null) return null;
        if (!string.IsNullOrEmpty(input.Link)) file.Link = input.Link;
        context.SaveChanges();
        return file;
    }

    public bool DeleteSharedFile(AppDbContext context, int id)
    {
        var file = context.SharedFiles.Find(id);
        if (file == null) return false;
        context.SharedFiles.Remove(file);
        context.SaveChanges();
        return true;
    }
}