using Store.Db.Interfaces;
using Store.Db.Entities;
using Store.Db.Models;
using RockLib.Logging;

namespace Store.Db.Repositories
{
    public class ClientsRepository : IClientsRepository
    {
        private readonly StoreDbContext _context;
        private readonly ILogger _logger;

        public ClientsRepository(StoreDbContext context, ILogger logger)
        {
           this._context = context;
            _logger = logger;
        }

        public ClientListView GetAllCustomers()
        {
            try
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

                if (clientList.Clients.Count > 0)
                {
                    _logger.Info("Returning all clients found");
                }
                else
                {
                    _logger.Info("No clients found");
                }

                return clientList;
            }
            catch (Exception ex)
            {
                _logger.Warn("Something wen't wrong in ClientsRepository");
                throw new Exception(ex.Message);
            }
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
