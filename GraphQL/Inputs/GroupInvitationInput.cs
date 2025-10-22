namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record GroupInvitationInput(int GroupId, int InvitingId, int InvitedId);
public record UpdateGroupInvitationInput(int Id, int? GroupId, int? InvitingId, int? InvitedId);