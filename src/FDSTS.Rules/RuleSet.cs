namespace FDSTS.Rules;

public sealed record RuleSet(string Name, string Version, DateTime EffectiveDate);

public static class CurrentRules
{
    public static RuleSet GetCurrent()
        => new("FDSTS Prototype Rules", "0.1", DateTime.Today);
}
