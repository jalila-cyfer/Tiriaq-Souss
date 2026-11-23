namespace PureHarvest.Models;

public class Recipe
{
    public string Slug { get; init; } = "";
    public string Title { get; init; } = "";
    public string Description { get; init; } = "";
    public string CategorySlug { get; init; } = "";      // miel | amlou | huile-argan
    public string Image { get; init; } = "";
    public int PrepMinutes { get; init; }
    public int CookMinutes { get; init; }
    public int Servings { get; init; }
    public string Difficulty { get; init; } = "Facile";
    public string[] Ingredients { get; init; } = Array.Empty<string>();
    public string[] Steps { get; init; } = Array.Empty<string>();

    public int TotalMinutes => PrepMinutes + CookMinutes;
}
