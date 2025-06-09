namespace BronzebeardDb.Models;

public record Item
(
    string Id, 
    string Name,
    string Source,
    Rarity Rarity,
    string Type,
    string Slot,
    int RequiresLevel,
    int ItemLevel,
    string Cost,
    string ZoneId,
    double X,
    double Y
)
{
    public string GetColor()
    {
        return Rarity switch
        {
            Rarity.Poor => "var(--poor-color)",
            Rarity.Uncommon => "var(--uncommon-color)",
            Rarity.Rare => "var(--rare-color)",
            Rarity.Epic => "var(--epic-color)",
            Rarity.Legendary => "var(--legendary-color)",
            Rarity.Vanity or Rarity.Artifact => "var(--vanity-color)",
            Rarity.Heirloom => "var(--heirloom-color)",
            Rarity.Unknown or Rarity.Common or _ => "var(--common-color)"
        };
    }
}

public enum Rarity
{
    Unknown,
    Poor,
    Common,
    Uncommon,
    Rare,
    Epic,
    Legendary,
    Vanity,
    Heirloom,
    Artifact
}
