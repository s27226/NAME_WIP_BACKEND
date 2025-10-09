namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record UserChatInput(int UserId, int ChatId);
public record UpdateUserChatInput(int Id, int? UserId, int? ChatId);