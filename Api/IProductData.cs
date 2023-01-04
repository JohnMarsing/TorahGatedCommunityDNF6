using Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api;

public interface IProductData
{
	Task<Product> AddProduct(Product product);
	Task<bool> DeleteProduct(int id);
	Task<IEnumerable<Product>> GetProducts();
	Task<Product> UpdateProduct(Product product);
}

