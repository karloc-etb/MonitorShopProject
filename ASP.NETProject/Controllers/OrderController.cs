using ASP.NETProject.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASP.NETProject.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        // GET: /<controller>/
        public IActionResult Checkout()
        {
            return View();
        }

        public RedirectToActionResult PreCheckout()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            //foreach (var item in items)
            //{
            //    var orderDetail = new OrderDetail()
            //    {
            //        Amount = item.Amount,
            //        MonitorId = item.Monitor.Id,
            //        OrderId = order.OrderId,
            //        Price = (decimal)item.Monitor.Price
            //    };

            //    _appDbContext.OrderDetails.Add(orderDetail);
            //}
            //_appDbContext.SaveChanges();

            var sCVM = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            

            return RedirectToAction("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            _shoppingCart.ClearCart();

            

            return View();
        }
    }
}
