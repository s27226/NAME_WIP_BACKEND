namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record UserRoleInput(string Name);
public record UpdateUserRoleInput(int Id, string? Name);