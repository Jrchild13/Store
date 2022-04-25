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
            _clientRepository = clientRepo;
            _clientsRepository = clientsRepo;
        }
        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }
        // GET: AdminController
        public ActionResult Clients()
        {
            var clients =  _clientsRepository.GetAllCustomers();

            return View(clients);
        }

        public ActionResult ClientOrders(int id)
        {
            var client = _clientRepository.GetAllOrders(id);
            
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
