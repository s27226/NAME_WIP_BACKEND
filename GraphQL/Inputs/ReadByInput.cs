namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record ReadByInput(int EntryId, int UserId);
public record UpdateReadByInput(int Id, int? EntryId, int? UserId);