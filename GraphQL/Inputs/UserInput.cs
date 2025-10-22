namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record UserInput(
    string Name,
    string Surname,
    string Nickname,
    string Email
);

public record UpdateUserInput(
    int Id,
    string? Name,
    string? Surname,
    string? Nickname,
    string? Email
);