﻿namespace BronzebeardDb.Models;

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
    decimal X,
    decimal Y
);

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
