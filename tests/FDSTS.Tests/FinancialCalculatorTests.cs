using FDSTS.Business;
using Xunit;

namespace FDSTS.Tests;

public class FinancialCalculatorTests
{
    [Fact]
    public void NetWorth_EqualsAssetsMinusLiabilities()
    {
        var result = FinancialCalculator.CalculateNetWorth(2_000_000m, 250_000m);
        Assert.Equal(1_750_000m, result);
    }
}
