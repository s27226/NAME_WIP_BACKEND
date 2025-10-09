using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;

public class UsersQuery
{
    [GraphQLName("allusers")]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<User> GetUsers([Service] AppDbContext context) => context.Users;
    [GraphQLName("getuserbyid")]
    [UseProjection]
    public User? GetUserById(AppDbContext context, int id) => context.Users.FirstOrDefault(g => g.Id == id);
    
}