namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record SharedFileInput(int ChatId, string Link);
public record UpdateSharedFileInput(int Id, string? Link);