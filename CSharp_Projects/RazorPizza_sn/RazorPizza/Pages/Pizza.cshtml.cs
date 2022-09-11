using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Margerita", PizzaName="Margerita", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Bolognese", PizzaName="Bolognese", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=9
            },
            new PizzasModel()
            {
                ImageTitle="Carbonara", PizzaName="Carbonara", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=3
            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian", PizzaName="Hawaiian", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=10
            },
            new PizzasModel()
            {
                ImageTitle="MeatFeast", PizzaName="MeatFeast", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Mushroom", PizzaName="Mushroom", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=8
            },
            new PizzasModel()
            {
                ImageTitle="Pepperoni", PizzaName="Pepperoni", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=8
            },
            new PizzasModel()
            {
                ImageTitle="Seafood", PizzaName="Seafood", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=15
            },
            new PizzasModel()
            {
                ImageTitle="Vegetarian", PizzaName="Vegetrian", BasePrice=2, TomatoSauce=true, Cheese=true, finalPrice=12
            },
        };
        public void OnGet()
        {
        }
    }
}
