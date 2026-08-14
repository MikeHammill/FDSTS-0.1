namespace FDSTS.Business;

public static class FinancialCalculator
{
    public static decimal CalculateNetWorth(decimal totalAssets, decimal totalLiabilities)
        => totalAssets - totalLiabilities;
}
