using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<User> GetUsers([Service] AppDbContext context) => context.Users;

    
}