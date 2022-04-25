using Store.Db.Interfaces;
using Store.Db.Entities;
using Store.Db.Models;

namespace Store.Db.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly StoreDbContext _context;

        public ClientRepository(StoreDbContext context) 
        {
            this._context = context;
        }

        public ClientsRecordView GetAllOrders(int id)
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
            return clientRecords;
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
