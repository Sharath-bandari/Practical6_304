using Practical6.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Practical6.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Products> products = new List<Products>();

            Products p1 = new Products();
            p1.Id = 1;
            p1.Name = "Mobile";
            p1.Category = "Electronics";
            p1.Price = 55000;
            p1.Description = "Google Pixel";

            Products p2 = new Products();
            p2.Id = 2;
            p2.Name = "Laptop";
            p2.Category = "Electronics";
            p2.Price = 90000;
            p2.Description = "Acer";

            Products p3 = new Products();
            p3.Id = 3;
            p3.Name = "Headset";
            p3.Category = "Accessory";
            p3.Price = 900;
            p3.Description = "Noise";

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            return View(products);
        }
    }
}
