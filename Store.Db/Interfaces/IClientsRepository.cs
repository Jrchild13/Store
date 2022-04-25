using Store.Db.Models;

namespace Store.Db.Interfaces
{
    public interface IClientsRepository
    {
        ClientListView GetAllCustomers();
        int AddOrders(ClientList record);
        ClientList GetById(int orderid);
    }
}
