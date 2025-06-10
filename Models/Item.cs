namespace BronzebeardDb.Models;

public class Item
{
    public string Id { get; set; }
    
    public string Name { get; set; }
    
    public string Source { get; set; }
    
    public Rarity Rarity { get; set; }
    
    public string Type { get; set; }
    
    public string Icon { get; set; }
    
    public int RequiresLevel { get; set; }
    
    public int ItemLevel { get; set; }
    
    public string Cost { get; set; }
    
    public double X { get; set; }
    
    public double Y { get; set; }

    public string Title => $"{Source} ({X}, {Y})";

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
