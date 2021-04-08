using System.Linq;

namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        
        //select * from products
        public IQueryable<Product> Products => context.Products;
    }
}
