namespace PureHarvest.Models;   // adaptez au namespace de votre projet

public record Category(string Slug, string Name);

public class Product
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public string Size { get; init; } = "";          // ex. "250 g"
    public decimal Price { get; init; }
    public double Rating { get; init; }              // 0 à 5
    public int Reviews { get; init; }
    public int SoldCount { get; init; }              // sert au classement "Best Sellers"
    public string CategorySlug { get; init; } = "";
    public string Image { get; init; } = "";
    public bool IsBestSeller { get; set; }           // calculé par le service
}
