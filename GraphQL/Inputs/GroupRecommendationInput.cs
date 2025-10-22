namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record GroupRecommendationInput(int UserId, int GroupId, int RecValue);
public record UpdateGroupRecommendationInput(int Id, int? UserId, int? GroupId, int? RecValue);