using EcommereceWeb.Application.Common;
using EcommereceWeb.Application.Interfaces.Repositories;
using EcommereceWeb.Domain.Entity;
using EcommereceWeb.Infrastraction.Data;


namespace EcommereceWeb.Infrstraction.Repositories
{
    public class ProductAttributeRepository : GenirecRopoistories<ProductAttribute>, IProductAttributeRepository
    {
        public ProductAttributeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public Task<IEnumerable<DataListItem>> GetDDL()
        {
            throw new NotImplementedException();
        }
      
        public List<List<ProductAttribute>> GetListVarationData()
        {  
            var res = _dbContext.ProductAttribute.Where(a => a.ProductId == 2).AsEnumerable().GroupBy(a => a.AttributeId);
            var attributeLists = new List<List<ProductAttribute>>();

            foreach (var i in res)
            {
                attributeLists.Add(i.ToList());



            }
            //var variations = GenerateVariations(attributeLists);
            //for (int i = 0; i < variations.Count; i++)
            //{
            //    variations[i].Id = i + 1;
            //}
            return attributeLists;
        }
    }

}
