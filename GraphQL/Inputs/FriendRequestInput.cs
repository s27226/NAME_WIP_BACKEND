namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record FriendRequestInput(int RequesterId, int RequesteeId);
public record UpdateFriendRequestInput(int Id, int? RequesterId, int? RequesteeId);