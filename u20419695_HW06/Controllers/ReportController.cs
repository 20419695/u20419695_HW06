using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20419695_HW06.Models;
using System.Data.Entity;

namespace u20419695_HW06.Controllers
{
    public class ReportController : Controller
    {
        private BikeStoresEntities db = new BikeStoresEntities();
        // GET: Report
        public ActionResult Index()
        {
            int[] months =
            {
                db.order_items.Where(m => m.order.order_date.Month == 1 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 2 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 3 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 4 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 5 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 6 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 7 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 8 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 9 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 10 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 11 && m.product.category_id == 6).ToList().Sum(m => m.quantity),
                db.order_items.Where(m => m.order.order_date.Month == 12 && m.product.category_id == 6).ToList().Sum(m => m.quantity)
            };
            return View(months);
        }
    }
}