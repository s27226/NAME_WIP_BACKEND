using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.GraphQL.Inputs;
using NAME_WIP_BACKEND.Models;

namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class ReadByMutation
{
    public ReadBy CreateReadBy(AppDbContext context, ReadByInput input)
    {
        var read = new ReadBy
        {
            EntryId = input.EntryId,
            UserId = input.UserId
        };
        context.ReadBys.Add(read);
        context.SaveChanges();
        return read;
    }

    public ReadBy? UpdateReadBy(AppDbContext context, UpdateReadByInput input)
    {
        var read = context.ReadBys.Find(input.Id);
        if (read == null) return null;
        if (input.EntryId.HasValue) read.EntryId = input.EntryId.Value;
        if (input.UserId.HasValue) read.UserId = input.UserId.Value;
        context.SaveChanges();
        return read;
    }

    public bool DeleteReadBy(AppDbContext context, int id)
    {
        var read = context.ReadBys.Find(id);
        if (read == null) return false;
        context.ReadBys.Remove(read);
        context.SaveChanges();
        return true;
    }
}