namespace NAME_WIP_BACKEND.Models;

public record UserRegisterInput(
    string Name,
    string Surname,
    string Nickname,
    string Email,
    string Password
);
