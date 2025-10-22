namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record UserGroupInput(int UserId, int GroupId);
public record UpdateUserGroupInput(int Id, int? UserId, int? GroupId);