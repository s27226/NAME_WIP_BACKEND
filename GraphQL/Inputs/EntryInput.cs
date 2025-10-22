namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record EntryInput(int UserChatId, string Message, bool Public);
public record UpdateEntryInput(int Id, string? Message, bool? Public);