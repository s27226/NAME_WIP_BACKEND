namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record ChatInput(
    int GroupId
);

public record UpdateChatInput(
    int Id,
    int? NewGroupId
);