using Microsoft.AspNetCore.Mvc;
using Store.Db.Interfaces;
using Store.Db.Entities;
using Store.Db.Repositories;

namespace Store.Admin
{
    public class AdminController : Controller
    {
        //private StoreDbContext context;
        private readonly IClientsRepository _clientsRepository;
        private readonly IClientRepository _clientRepository;
        public AdminController(IClientRepository clientRepo, IClientsRepository clientsRepo)
        {
            _clientRepository = clientRepo; //  new ClientRepository(new StoreDbContext());
            _clientsRepository = clientsRepo; // new ClientsRepository(new StoreDbContext());
        }
        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
        // GET: AdminController
        public ActionResult Clients()
        {

            var clients =  _clientsRepository.GetAllCustomers();


            //var clients = new ClientListView();
            //var db = new StoreDbContext();
            //clients.ClientsRecords = (from r in db.Customers                                 
            //                          select new ClientView { Address = r.Address, 
            //                                                                 Birthday = r.BirthDate.ToString(),
            //                                                                 Points = r.Points,
            //                                                                 Name = r.FirstName + " " + r.LastName,
            //                                                                 ClientId = r.CustomerId}).ToList();
            return View(clients);
        }

        public ActionResult ClientOrders(int id)
        {
            var client = _clientRepository.GetAllOrders(id);
            
            /*var db = new StoreDbContext();
            var client = new ClientsListView
            {
                Name = (from c in db.Customers
                        where c.CustomerId == id
                        select new ClientsView
                        {
                            Name = c.FirstName + " " + c.LastName 
                    }).ToList(),

                Orders = (from o in db.Orders
                          join oi in db.OrderItems on o.OrderId equals oi.OrderId
                          join p in db.Products on oi.ProductId equals p.ProductId
                          where o.CustomerId == id
                          select new ClientsView
                          {
                              OrderId = o.OrderId,
                              Quantity = oi.Quantity,
                              UnitPrice = p.UnitPrice,
                              Name = p.Name
                          }).ToList(),
            }; */
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
        public ActionResult Edit()
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
        public ActionResult Delete()
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
