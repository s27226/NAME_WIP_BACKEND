namespace NAME_WIP_BACKEND.GraphQL.Inputs;

public record FriendRecommendationInput(int UserId, int RecommendedId, int RecValue);
public record UpdateFriendRecommendationInput(int Id, int? UserId, int? RecommendedId, int? RecValue);