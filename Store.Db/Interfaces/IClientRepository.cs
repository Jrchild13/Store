using Store.Db.Models;

namespace Store.Db.Interfaces
{
    public interface IClientRepository
    {
        ClientsRecordView GetAllOrders(int id);
        int AddOrders(ClientsRecord record);
        ClientsRecord GetById(int id);
    }
}
