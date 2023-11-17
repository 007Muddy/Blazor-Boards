using System.ComponentModel.DataAnnotations;

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
        public int ID { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        public string? Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Thickness { get; set; }
        public double Volume { get; set; }
        public string? Type { get; set; }
        public Decimal Price { get; set; }
        public string? Equipment { get; set; }
        public bool Reserved { get; set; }
        public string? Image { get; set; }
        [Required(ErrorMessage = "Please choese a startdate")]

        public DateTime StartDate { get; set; }
        [Required(ErrorMessage = "Please choese a enddate")]
        public DateTime EndDate { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        /// <summary>
        /// The route slug of the product.
        /// </summary>
        public string Slug
        {
            get
            {
                return ID.ToString();
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

        public ProductModel(int id, string? name, double length, double width, double thickness, double volume, string? type, decimal price, string? equipment, bool reserved, string? image, DateTime startDate, DateTime endDate, byte[] rowVersion)
        {
            ID = id;
            Name = name;
            Length = length;
            Width = width;
            Thickness = thickness;
            Volume = volume;
            Type = type;
            Price = price;
            Equipment = equipment;
            Reserved = reserved;
            Image = image;
            StartDate = startDate;
            EndDate = endDate;
            RowVersion = rowVersion;
        }

        /// <summary>
        /// Constructs a new product.
        /// </summary>
        /// <param name="sku">Unique identifier of the product.</param>
        /// <param name="name">Name of the product.</param>
        /// <param name="price">Price of the product.</param>
        /// <param name="image">Image path of the product.</param>


    }
}
