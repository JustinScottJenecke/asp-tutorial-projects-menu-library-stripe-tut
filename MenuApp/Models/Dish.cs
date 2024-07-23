using System.ComponentModel.DataAnnotations;

namespace MenuApp.Models;

public class Dish
{
    public int Id {get; set;}

    [Required]
    public string Name {get; set;}

    public String ImageUrl {get; set;}

    public Double Price {get; set;}

    public List<DishIngredient>? DishIngredients { get; set; }
}
