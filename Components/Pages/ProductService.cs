using PureHarvest.Models;

namespace PureHarvest.Services;

public class ProductService
{
    public IReadOnlyList<Category> Categories { get; } = new List<Category>
    {
        new("miel", "Miel"),
        new("amlou", "Amlou"),
        new("huile-argan", "Huile d'argan"),
        new("noix-miel", "Noix au miel"),
    };


    private readonly List<Product> _products = new()
    {
        new() { Id = 1,  Name = "Miel de Cression bio", Size = "500 g", Price = 130m, Rating = 4.6, Reviews = 512, SoldCount = 2100, CategorySlug = "miel", Image = "images/products/Miel-Cresson.png" },
        new() { Id = 2,  Name = "Miel de thym bio", Size = "500 g", Price = 210m, Rating = 4.8, Reviews = 389, SoldCount = 1650, CategorySlug = "miel", Image = "images/products/Miel-Thym.png" },
        new() { Id = 3,  Name = "Miel Farnan bio", Size = "500 g", Price = 160m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Farnan.png" },
        new() { Id = 4,  Name = "Miel de Printemps", Size = "500 g", Price = 70m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Farnan.png" },
        new() { Id = 5,  Name = "Miel de Fenouil", Size = "500 g", Price = 130m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Fenouil.png" },
        new() { Id = 6,  Name = "Miel de Chardon", Size = "500 g", Price = 130m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Chardon.png" },
        new() { Id = 7,  Name = "Miel D'heuphorbe", Size = "500 g", Price = 180m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-heuphorbe.png" },
        new() { Id = 8,  Name = "Miel D'oranger", Size = "500 g", Price = 60m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-oranger.png" },
        new() { Id = 9,  Name = "Miel D'herbs", Size = "500 g", Price = 60m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-herbs.png" },
        new() { Id = 10, Name = "Miel D'heucalyptus", Size = "500 g", Price = 90m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-euca.png" },
        new() { Id = 11, Name = "Amlou de cajou,L'huile d'amande, Argan et miel naturel", Size = "500 g", Price = 130m, Rating = 4.7, Reviews = 956, SoldCount = 3200, CategorySlug = "amlou", Image = "images/products/amlou-kajou.png" },
        new() { Id = 12, Name = "Graines de courge, Huiled'olive et miel naturel", Size = "500 g", Price = 75m, Rating = 4.4, Reviews = 318, SoldCount = 860, CategorySlug = "amlou", Image = "images/products/amlou-vert.png" },
        new() { Id = 13, Name = "Huile d'argan alimentaire", Size = "500 ml", Price = 320m, Rating = 4.8, Reviews = 875, SoldCount = 2850, CategorySlug = "huile-argan", Image = "images/products/huile-argan.png" },
        new() { Id = 14, Name = "Huile d'argan cosmétique", Size = "30 ml", Price = 45m, Rating = 4.5, Reviews = 732, SoldCount = 1750, CategorySlug = "huile-argan", Image = "images/products/huile-argan-Shininguxe.png" },
        new() { Id = 15, Name = "Miel de Jujubier bio", Size = "250 g", Price = 130m, Rating = 4.6, Reviews = 512, SoldCount = 2100, CategorySlug = "miel", Image = "images/products/Miel-Jujubier.png" },
        new() { Id = 16, Name = "Miel de Caroubier bio", Size = "500 g", Price = 120m, Rating = 4.8, Reviews = 389, SoldCount = 1650, CategorySlug = "miel", Image = "images/products/Miel-Caroubier.png" },
        new() { Id = 17, Name = "Miel de Genevrier bio", Size = "500 g", Price = 160m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Genevrier.png" },
        new() { Id = 18, Name = "Noix au Miel", Size = "400 g", Price = 120m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Noix-Miel.png" },

        new() { Id = 19, Name = "Miel de Cression bio", Size = "1 kg", Price = 250m, Rating = 4.6, Reviews = 512, SoldCount = 2100, CategorySlug = "miel", Image = "images/products/Miel-Cresson.png" },
        new() { Id = 20, Name = "Miel de thym bio", Size = "1 kg", Price = 400m, Rating = 4.8, Reviews = 389, SoldCount = 1650, CategorySlug = "miel", Image = "images/products/Miel-Thym.png" },
        new() { Id = 21, Name = "Miel Farnan bio", Size = "1 kg", Price = 300m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Farnan.png" },
        new() { Id = 22, Name = "Miel de Printemps", Size = "1 kg", Price = 120m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Farnan.png" },
        new() { Id = 23, Name = "Miel de Fenouil", Size = "1 kg", Price = 250m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Fenouil.png" },
        new() { Id = 24, Name = "Miel de Chardon", Size = "1 kg", Price = 250m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Chardon.png" },
        new() { Id = 25, Name = "Miel D'heuphorbe", Size = "1 kg", Price = 350m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-heuphorbe.png" },
        new() { Id = 26, Name = "Miel D'oranger", Size = "1 kg", Price = 120m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-oranger.png" },
        new() { Id = 27, Name = "Miel D'herbs", Size = "1 kg", Price = 120m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-herbs.png" },
        new() { Id = 28, Name = "Miel D'heucalyptus", Size = "1 kg", Price = 180m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-euca.png" },
        new() { Id = 29, Name = "cacahuetes, Huile d'olive, miel Naturelle, sesame", Size = "500 g", Price = 45m, Rating = 4.6, Reviews = 604, SoldCount = 1980, CategorySlug = "amlou", Image = "images/products/amlou-herb.png" },
        new() { Id = 30, Name = "Amande, L'huile d'argan miel d'orange", Size = "500 g", Price = 90m, Rating = 4.7, Reviews = 956, SoldCount = 3200, CategorySlug = "amlou", Image = "images/products/amlou-amande-miel-orange.png" },
        new() { Id = 31, Name = "Amande, L'huile d'argan miel d'orange", Size = "700 g", Price = 180m, Rating = 4.7, Reviews = 956, SoldCount = 3200, CategorySlug = "amlou", Image = "images/products/amlou-amande-miel-orange.png" },
        new() { Id = 32, Name = "Huile d'argan alimentaire", Size = "1 L", Price = 600m, Rating = 4.8, Reviews = 875, SoldCount = 2850, CategorySlug = "huile-argan", Image = "images/products/huile-argan.png" },
        new() { Id = 33, Name = "Huile d'argan alimentaire", Size = "250 ml", Price = 165m, Rating = 4.8, Reviews = 875, SoldCount = 2850, CategorySlug = "huile-argan", Image = "images/products/huile-argan.png" },
        new() { Id = 34, Name = "Huile d'argan cosmétique", Size = "100 ml", Price = 100m, Rating = 4.5, Reviews = 732, SoldCount = 1750, CategorySlug = "huile-argan", Image = "images/products/argan-noir-or.png" },
        new() { Id = 35, Name = "Miel de Jujubier bio", Size = "1 kg", Price = 250m, Rating = 4.6, Reviews = 512, SoldCount = 2100, CategorySlug = "miel", Image = "images/products/Miel-Jujubier.png" },
        new() { Id = 36, Name = "Miel de Caroubier bio", Size = "1 kg", Price = 230m, Rating = 4.8, Reviews = 389, SoldCount = 1650, CategorySlug = "miel", Image = "images/products/Miel-Caroubier.png" },
        new() { Id = 37, Name = "Miel de Genevrier bio", Size = "1 kg", Price = 300m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Miel-Genevrier.png" },
        new() { Id = 38, Name = "Noix au Miel", Size = "800 g", Price = 210m, Rating = 4.5, Reviews = 201, SoldCount = 740, CategorySlug = "miel", Image = "images/products/Noix-Miel.png" },
    };


    public ProductService()
    {
        // Les 6 produits les plus vendus reçoivent le badge "Best seller"
        foreach (var p in _products.OrderByDescending(p => p.SoldCount).Take(6))
            p.IsBestSeller = true;
    }

    public IReadOnlyList<Product> GetAll() => _products;

    public IReadOnlyList<Product> GetByCategory(string slug) =>
        _products.Where(p => p.CategorySlug == slug).ToList();

    public IReadOnlyList<Product> GetBestSellers(int count = 6) =>
        _products.OrderByDescending(p => p.SoldCount).Take(count).ToList();

    public Category? FindCategory(string slug) =>
        Categories.FirstOrDefault(c => c.Slug == slug);
}
