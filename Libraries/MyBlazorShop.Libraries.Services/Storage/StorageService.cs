using MyBlazorShop.Libraries.Services.Product.Models;
using MyBlazorShop.Libraries.Services.ShoppingCart.Models;
using System.Net.Http.Json;

namespace MyBlazorShop.Libraries.Services.Storage
{
    /// <summary>
    /// Stores the data used for the application.
    /// </summary>
    public class StorageService : IStorageService
    {
        /// <summary>
        /// Stores a list of products.
        /// </summary>
        public IList<ProductModel> Products { get; private set; }

        /// <summary>
        /// Stores the shopping cart.        
        /// </summary>
        public ShoppingCartModel ShoppingCart { get; private set; }

        /// <summary>
        ///  Constructs a storage service.
        /// </summary>
        public StorageService()
        {
            Products = new List<ProductModel>();
            ShoppingCart = new ShoppingCartModel();
            
            // Store a list of all the products for the online shop.
            //AddProduct(new ProductModel("SKU12345", "The Minilog", 6, 21, 2.75, 38.8, "Shortboard", 565M, "", "download (1).jpg"));
            //AddProduct(new ProductModel("SKU67890", "The Wide Glider", 7.16, 21.75, 2.75, 44.16, "Funboard", 685M, "", "download.jpg"));
            //AddProduct(new ProductModel("SKU24680", "The Golden Ratio", 6.3, 21.85, 2.9, 43.22, "Funboard", 695M, "", "images.png"));

        }

     public async Task GetBoardsFromApi(HttpClient httpClient)
        {
            Products = await httpClient.GetFromJsonAsync<List<ProductModel>>(@"https://localhost:7071/api/Boards/GetAllBoards");
            //if (response.IsSuccessStatusCode)
            //{
            //    var result = await response.Content.ReadFromJsonAsync<List<ProductModel>>();
            //    if (result != null)
            //    {
            //        Products = result;

            //    }
            //    else
            //    {

            //        throw new Exception("Result of API invalid");
            //    }
            //}
            //else
            //{

            //    throw new Exception("Api call is working correctly" + response.StatusCode.ToString());
            
            //}
           
        }



        /// <summary>
        /// Adds a product to the storage.
        /// </summary>
        /// <param name="productModel">The <see cref="ProductModel"/> type to be added.</param>
        private void AddProduct(ProductModel productModel)
            {
                if (!Products.Any(p => p.Sku == productModel.Sku))
                {
                    Products.Add(productModel);
                }
            }
        }
    }
