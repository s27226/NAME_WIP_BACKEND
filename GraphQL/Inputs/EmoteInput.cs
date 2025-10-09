namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record EmoteInput(string Name);
public record UpdateEmoteInput(int Id, string? Name);