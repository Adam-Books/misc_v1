using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Cheese) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Peperoni) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Mushroom) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Tuna) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Pineapple) PizzaPrice = PizzaPrice + 10;
            if (Pizza.Meat) PizzaPrice = PizzaPrice + 1;
            if (Pizza.Beef) PizzaPrice = PizzaPrice + 1;

            return RedirectToPage("/Checkout/Checkout", new { Pizza.PizzaName, PizzaPrice });
        }
    }
}
