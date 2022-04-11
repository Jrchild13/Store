using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using online_store.Models;
using online_store.ViewModels;

namespace online_store.Admin
{
    public class AdminController : Controller
    {
        // GET: AdminController
        public ActionResult Clients()
        {
            var clients = new ClientRowListView();
            storeContext db = new storeContext();
            clients.ClientsRecords = (from r in db.Customers                                 
                                      select new ClientRowView { Address = r.Address, 
                                                                             Birthday = r.BirthDate.ToString(),
                                                                             Points = r.Points,
                                                                             Name = r.FirstName + " " + r.LastName,
                                                                             ClientId = r.CustomerId}).ToList();
            return View(clients);
        }
        public ActionResult Client(int id)
        {
            var client = new OrderRowListView();
            storeContext dc = new storeContext();

            client.Name = (from c in dc.Customers
                                 where c.CustomerId == id
                                 select c.FirstName +  " " + c.LastName).FirstOrDefault();

            storeContext db = new storeContext();

            client.Orders = (from o in db.Orders
                             join c in db.Customers on o.CustomerId equals c.CustomerId
                             join oi in db.OrderItems on o.OrderId equals oi.OrderId
                             join p in db.Products on oi.ProductId equals p.ProductId
                             where c.CustomerId == id
                             select new OrderRowView
                             {
                                 OrderId = o.OrderId,
                                 Quantity = oi.Quantity,
                                 ProductPrice = p.UnitPrice,
                                 ProductName = p.Name,
                             }).ToList();

            return View(client);    
        }
        

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
