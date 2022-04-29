using Store.Db.Interfaces;
using Store.Db.Entities;
using Store.Db.Models;
using RockLib.Logging;

namespace Store.Db.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly StoreDbContext _context;
        private readonly ILogger _logger;
        public ClientRepository(StoreDbContext context, ILogger logger) 
        {
            _context = context;
            _logger = logger;
        }

        public ClientsRecordView GetAllOrders(int id)
        {
            try
            {
                var clientRecords = new ClientsRecordView
                {
                    ClientName = (from c in _context.Customers
                                  where c.CustomerId == id
                                  select new ClientsRecord
                                  {
                                      Name = c.FirstName + " " + c.LastName,
                                  }).ToList(),

                    ClientOrders = (from o in _context.Orders
                                    join oi in _context.OrderItems on o.OrderId equals oi.OrderId
                                    join p in _context.Products on oi.ProductId equals p.ProductId
                                    where o.CustomerId == id
                                    select new ClientsRecord
                                    {
                                        OrderId = o.OrderId,
                                        ProductName = p.Name,
                                        Quantity = oi.Quantity,
                                        UnitPrice = p.UnitPrice,
                                    }).ToList(),
                };
                if (clientRecords.ClientOrders.Count > 0)
                {
                    _logger.Debug("Returning orders found for this client");
                }
                else
                {
                    _logger.Debug("No orders found for this client");
                }

                return clientRecords;
            }
            catch (Exception ex)
            {
                _logger.Error("Something wen't wrong in ClientRepository");
                throw new Exception(ex.Message);
            }
        }

        public int AddOrders(ClientsRecord record)
        {
            throw new NotImplementedException();
        }        

        public ClientsRecord GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
