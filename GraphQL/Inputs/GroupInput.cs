namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record GroupInput(
    string Name,
    string? Desc
);

public record UpdateGroupInput(
    int Id,
    string? Name,
    string? Desc
);