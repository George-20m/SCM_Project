using Grpc.Core;
using System.Threading.Tasks;

namespace GrpcService.Services // Ensure this namespace is correct
{
	public class ProductServiceImpl : ProductService.ProductServiceBase
	{
		public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
		{
			// Handle invalid product IDs
			if (request.ProductId <= 0)
			{
				return Task.FromResult(new ProductResponse
				{
					ProductDetails = "Error: Invalid Product ID. Product ID must be greater than 0."
				});
			}

			// Fetch product details (simulated with a method)
			string productDetails = GetProductDetailsFromDatabase(request.ProductId);
			if (string.IsNullOrEmpty(productDetails))
			{
				productDetails = $"No details found for Product ID: {request.ProductId}.";
			}

			return Task.FromResult(new ProductResponse
			{
				ProductDetails = productDetails
			});
		}

		private string GetProductDetailsFromDatabase(int productId)
		{
			return productId switch
			{
				1 => "Product ID 1: A great product for your needs.",
				2 => "Product ID 2: Another excellent product, perfect for professionals.",
				3 => "Product ID 3: This product will change your life!",
				_ => string.Empty  // Return an empty string instead of null to avoid warnings
			};
		}
	}
}