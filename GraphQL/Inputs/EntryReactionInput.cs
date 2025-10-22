namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record EntryReactionInput(int UserId, int EntryId, int EmoteId);
public record UpdateEntryReactionInput(int Id, int? EmoteId);