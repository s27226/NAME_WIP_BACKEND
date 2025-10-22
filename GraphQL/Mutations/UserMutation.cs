using NAME_WIP_BACKEND.Data;
using NAME_WIP_BACKEND.Models;
using NAME_WIP_BACKEND.GraphQL.Inputs;


namespace NAME_WIP_BACKEND.GraphQL.Mutations;

public class UserMutation
{
    public User CreateUser(AppDbContext context, UserInput input)
    {
        var user = new User
        {
            Name = input.Name,
            Surname = input.Surname,
            Nickname = input.Nickname,
            Email = input.Email,
            Password = "hashed-password",
            Joined = DateTime.UtcNow,
            DateOfBirth = DateTime.UtcNow.AddYears(-20),
            UserRoleId = 1
        };

        context.Users.Add(user);
        context.SaveChanges();
        return user;
    }

    public User? UpdateUser(AppDbContext context, UpdateUserInput input)
    {
        var user = context.Users.Find(input.Id);
        if (user == null) return null;

        if (!string.IsNullOrEmpty(input.Name)) user.Name = input.Name;
        if (!string.IsNullOrEmpty(input.Surname)) user.Surname = input.Surname;
        if (!string.IsNullOrEmpty(input.Nickname)) user.Nickname = input.Nickname;
        if (!string.IsNullOrEmpty(input.Email)) user.Email = input.Email;

        context.SaveChanges();
        return user;
    }

    public bool DeleteUser(AppDbContext context, int id)
    {
        var user = context.Users.Find(id);
        if (user == null) return false;
        context.Users.Remove(user);
        context.SaveChanges();
        return true;
    }
}