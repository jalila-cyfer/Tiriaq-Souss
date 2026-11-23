using PureHarvest.Models;

namespace PureHarvest.Services;

public class RecipeService
{
    private readonly List<Recipe> _recipes = new()
    {
        // ===================== MIEL =====================
        new()
        {
            Slug = "yaourt-miel-noix", CategorySlug = "miel",
            Title = "Bol de yaourt, miel et noix",
            Description = "Un petit-déjeuner crémeux et croquant, prêt en 5 minutes.",
            Image = "images/recipes/yaourt-miel-noix.jpg",
            PrepMinutes = 5, CookMinutes = 0, Servings = 2, Difficulty = "Facile",
            Ingredients = new[] { "300 g de yaourt grec nature", "3 c. à soupe de miel d'oranger bio", "40 g de noix concassées", "1 banane en rondelles", "1 pincée de cannelle" },
            Steps = new[] { "Répartissez le yaourt dans deux bols.", "Disposez les rondelles de banane et les noix concassées.", "Nappez de miel et saupoudrez de cannelle. Servez aussitôt." }
        },
        new()
        {
            Slug = "poulet-miel-thym", CategorySlug = "miel",
            Title = "Poulet rôti au miel et au thym",
            Description = "Une peau dorée et caramélisée, une chair fondante.",
            Image = "images/recipes/poulet-miel-thym.jpg",
            PrepMinutes = 15, CookMinutes = 45, Servings = 4, Difficulty = "Facile",
            Ingredients = new[] { "4 cuisses de poulet", "3 c. à soupe de miel de thym bio", "2 c. à soupe de sauce soja", "3 gousses d'ail écrasées", "Thym frais, sel et poivre", "1 c. à soupe d'huile d'olive" },
            Steps = new[] { "Mélangez le miel, la sauce soja, l'ail, l'huile et le thym.", "Badigeonnez les cuisses de poulet et laissez mariner 30 minutes.", "Enfournez 45 minutes à 190 °C en arrosant à mi-cuisson.", "Servez avec les sucs de cuisson." }
        },
        new()
        {
            Slug = "granola-miel", CategorySlug = "miel",
            Title = "Granola maison au miel",
            Description = "Croustillant, peu sucré et bien meilleur que celui du commerce.",
            Image = "images/recipes/granola-miel.jpg",
            PrepMinutes = 10, CookMinutes = 25, Servings = 8, Difficulty = "Facile",
            Ingredients = new[] { "250 g de flocons d'avoine", "100 g d'amandes et de noisettes", "4 c. à soupe de miel bio", "3 c. à soupe d'huile de coco", "1 c. à café de cannelle", "50 g de raisins secs" },
            Steps = new[] { "Faites tiédir le miel avec l'huile de coco.", "Mélangez avec l'avoine, les fruits secs et la cannelle.", "Étalez sur une plaque et enfournez 25 minutes à 160 °C en remuant deux fois.", "Ajoutez les raisins secs après refroidissement." }
        },

        // ===================== AMLOU =====================
        new()
        {
            Slug = "tartines-amlou-banane", CategorySlug = "amlou",
            Title = "Tartines à l'amlou et à la banane",
            Description = "Le goûter marocain par excellence : amandes, argan et miel.",
            Image = "images/recipes/tartines-amlou-banane.jpg",
            PrepMinutes = 5, CookMinutes = 2, Servings = 2, Difficulty = "Facile",
            Ingredients = new[] { "4 tranches de pain complet", "4 c. à soupe d'amlou traditionnel", "1 banane", "1 filet de miel", "Quelques amandes effilées" },
            Steps = new[] { "Faites griller légèrement le pain.", "Tartinez généreusement d'amlou.", "Ajoutez les rondelles de banane, un filet de miel et les amandes effilées." }
        },
        new()
        {
            Slug = "smoothie-bowl-amlou", CategorySlug = "amlou",
            Title = "Smoothie bowl à l'amlou",
            Description = "Épais, énergisant et plein de bons gras.",
            Image = "images/recipes/smoothie-bowl-amlou.jpg",
            PrepMinutes = 10, CookMinutes = 0, Servings = 1, Difficulty = "Facile",
            Ingredients = new[] { "1 banane congelée", "100 g de fruits rouges", "150 ml de lait d'amande", "1 c. à soupe d'amlou", "Granola, graines de chia, fruits frais pour le dressage" },
            Steps = new[] { "Mixez la banane, les fruits rouges, le lait d'amande et l'amlou jusqu'à obtenir une texture épaisse.", "Versez dans un bol.", "Garnissez de granola, de chia et de fruits frais." }
        },
        new()
        {
            Slug = "cookies-amlou", CategorySlug = "amlou",
            Title = "Cookies à l'amlou",
            Description = "Moelleux au cœur, croustillants sur les bords, avec une note de noisette.",
            Image = "images/recipes/cookies-amlou.jpg",
            PrepMinutes = 15, CookMinutes = 12, Servings = 12, Difficulty = "Moyen",
            Ingredients = new[] { "120 g d'amlou", "80 g de sucre de canne", "1 œuf", "150 g de farine complète", "1/2 sachet de levure", "80 g de pépites de chocolat noir" },
            Steps = new[] { "Mélangez l'amlou, le sucre et l'œuf.", "Incorporez la farine, la levure puis les pépites de chocolat.", "Formez 12 boules sur une plaque et aplatissez légèrement.", "Enfournez 12 minutes à 180 °C et laissez refroidir avant de décoller." }
        },

        // ===================== HUILE D'ARGAN =====================
        new()
        {
            Slug = "salade-fraises-argan", CategorySlug = "huile-argan",
            Title = "Salade de fraises à l'huile d'argan",
            Description = "Fraîche, sucrée et légèrement toastée : une salade surprenante.",
            Image = "images/recipes/salade-fraises-argan.jpg",
            PrepMinutes = 10, CookMinutes = 0, Servings = 2, Difficulty = "Facile",
            Ingredients = new[] { "250 g de fraises", "1 poignée de roquette", "50 g de feta émiettée", "2 c. à soupe d'huile d'argan alimentaire", "1 c. à soupe de vinaigre balsamique", "Quelques feuilles de menthe" },
            Steps = new[] { "Coupez les fraises en quartiers.", "Disposez-les sur la roquette avec la feta et la menthe.", "Assaisonnez avec l'huile d'argan, le balsamique, du sel et du poivre." }
        },
        new()
        {
            Slug = "houmous-argan", CategorySlug = "huile-argan",
            Title = "Houmous à l'huile d'argan",
            Description = "Un houmous onctueux avec un parfum de noisette grillée.",
            Image = "images/recipes/houmous-argan.jpg",
            PrepMinutes = 10, CookMinutes = 0, Servings = 4, Difficulty = "Facile",
            Ingredients = new[] { "400 g de pois chiches cuits", "2 c. à soupe de tahini", "Le jus d'un citron", "1 gousse d'ail", "3 c. à soupe d'huile d'argan culinaire bio", "Paprika et sel" },
            Steps = new[] { "Mixez les pois chiches, le tahini, le citron, l'ail et un peu d'eau froide.", "Ajoutez 2 c. à soupe d'huile d'argan et mixez de nouveau.", "Servez avec un filet d'argan et du paprika, avec du pain pita ou des crudités." }
        },
        new()
        {
            Slug = "carpaccio-betterave-argan", CategorySlug = "huile-argan",
            Title = "Carpaccio de betterave à l'huile d'argan",
            Description = "Une entrée colorée, élégante et très rapide.",
            Image = "images/recipes/carpaccio-betterave-argan.jpg",
            PrepMinutes = 15, CookMinutes = 0, Servings = 4, Difficulty = "Facile",
            Ingredients = new[] { "3 betteraves cuites", "2 c. à soupe d'huile d'argan alimentaire", "1 c. à soupe de jus de citron", "50 g de fromage de chèvre frais", "2 c. à soupe d'amandes grillées", "Sel, poivre" },
            Steps = new[] { "Tranchez finement les betteraves et dressez-les en rosace.", "Émiettez le fromage de chèvre et parsemez d'amandes.", "Arrosez d'huile d'argan et de citron, puis assaisonnez." }
        },
    };

    public IReadOnlyList<Recipe> GetAll() => _recipes;

    public IReadOnlyList<Recipe> GetByCategory(string slug) =>
        _recipes.Where(r => r.CategorySlug == slug).ToList();

    public Recipe? FindBySlug(string slug) =>
        _recipes.FirstOrDefault(r => r.Slug == slug);
}
