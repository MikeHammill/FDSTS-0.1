namespace FDSTS.Business;

public sealed record Observation(
    string Category,
    string Finding,
    string Explanation,
    string SuggestedReview,
    string Priority);

public static class ObservationEngine
{
    public static Observation? MissingCostBasis(decimal? costBasis, bool isTaxableAccount)
    {
        if (!isTaxableAccount || costBasis.HasValue)
            return null;

        return new Observation(
            "Account Management",
            "Cost basis information is incomplete.",
            "Future tax planning may require accurate cost basis information.",
            "Review the account and update the cost basis.",
            "Medium");
    }
}
