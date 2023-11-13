namespace MyBlazorShop.Libraries.Services.Product.Models
{
    /// <summary>
    /// Stores a product.
    /// </summary>
    public class ProductModel
    {
      
        /// <summary>
        /// Unique identifier of the product.
        /// </summary>
        public string Sku { get; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Price of the product.
        /// </summary>

        public double Length { get;  }

        public double Width { get;  }

        public double Thickness { get; }

        public double Volume { get; }

        public string Type { get; set; }

        public decimal Price { get; }

        public string?  Equimpent { get; }
        /// <summary>
        /// The image path of the product.
        /// </summary>
        public string? Image { get; }

        /// <summary>
        /// The route slug of the product.
        /// </summary>
        public string Slug
        {
            get
            {
                return Sku.ToLower();
            }
        }

        /// <summary>
        /// The full URL of the product
        /// </summary>
        public string FullUrl
        {
            get
            {
                return string.Format("/product/{0}", Slug);
            }
        }

        /// <summary>
        /// Constructs a new product.
        /// </summary>
        /// <param name="sku">Unique identifier of the product.</param>
        /// <param name="name">Name of the product.</param>
        /// <param name="price">Price of the product.</param>
        /// <param name="image">Image path of the product.</param>
        public ProductModel(string sku, string name, double length, double width, double thikness, double volume, string type, decimal price, string equimpent, string image)
        {
            Sku = sku;
            Name = name;
            Length = length;
            Width = width;
            Thickness = thikness;
            Volume = volume;
            Type = type;
            Price = price;
            Equimpent = equimpent;
            Image = image;
        }

    }
}
