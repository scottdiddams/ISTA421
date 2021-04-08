using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsStore.Infrastructure;
using SportsStore.Models;
using System.Linq;

namespace SportsStore.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            Cart.AddItem(product, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
    //The class associated with a Razor Page is known as its page model class,
    //and it defines handler methods that are invoked for different types of
    //HTTP requests, which update state before rendering the view. The page
    //model class in Listing 8-25, which is named CartModel, defines an OnPost
    //hander method, which is invoked to handle HTTP POST requests. It does this
    //by retrieving a Product from the database, retrieving the user’s Cart
    //from the session data, and updating its content using the Product.
    //The modified Cart is stored, and the browser is redirected to the same
    //Razor Page, which it will do using a GET request (which prevents
    //reloading the browser from triggering a duplicate POST request).
}
