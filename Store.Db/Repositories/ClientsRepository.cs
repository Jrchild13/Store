using Store.Db.Interfaces;
using Store.Db.Entities;
using Store.Db.Models;

namespace Store.Db.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly StoreDbContext _context;
        public ClientsRepository(StoreDbContext context)
        {
           this._context = context;
        }

        public ClientListView GetAllCustomers()
        {
            var clientList = new ClientListView
            {
                Clients = (from c in _context.Customers
                           select new ClientList
                           {
                               Name = c.FirstName + " " + c.LastName,
                               CustomerId = c.CustomerId,
                               BirthDate = c.BirthDate,
                               Address = c.Address,
                               Points = c.Points,
                           }).ToList(),
            };
            return clientList;
        }

        public int AddOrders(ClientList record)
        {
            throw new NotImplementedException();
        }

        public ClientList GetById(int orderid)
        {
            throw new NotImplementedException();
        }
    }
}
