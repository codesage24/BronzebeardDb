namespace BronzebeardDb.Models;

public class Item
{
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string Source { get; set; }
    
    public Rarity? Rarity { get; set; }
    
    public string Type { get; set; }
    
    public string Icon { get; set; }

    public string Notes { get; set; }
    
    public int RequiresLevel { get; set; }
    
    public int ItemLevel { get; set; }
    
    public string Cost { get; set; }
    
    public double X { get; set; }
    
    public double Y { get; set; }

    public string Title => $"{Source} ({X}, {Y})";

    public string GetColor()
    {
        if (!Rarity.HasValue)
        {
            return "var(--common-color)";
        }

        return Rarity.Value switch
        {
            Models.Rarity.Poor => "var(--poor-color)",
            Models.Rarity.Uncommon => "var(--uncommon-color)",
            Models.Rarity.Rare => "var(--rare-color)",
            Models.Rarity.Epic => "var(--epic-color)",
            Models.Rarity.Legendary => "var(--legendary-color)",
            Models.Rarity.Vanity => "var(--vanity-color)",
            Models.Rarity.Heirloom => "var(--heirloom-color)",
            Models.Rarity.Artifact => "var(--artifact-color)",
            _ => "var(--common-color)"
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
