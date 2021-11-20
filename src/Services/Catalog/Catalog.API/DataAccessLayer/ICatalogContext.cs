using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.DataAccessLayer
{
    public interface ICatalogContext
    {
        IMongoCollection<Product> Products { get; }
    }
}
