using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WA_EShop
{
    public class ProductViewModels
    {
        [DisplayName("Ürün Numarası")]
        public int ProductId { get; set; }
        [DisplayName("Ürün Adı")]
        [MaxLength(50), MinLength(2)]
        public string ProductName { get; set; } = null!;
        [DisplayName("Ürün Açıklaması")]
        [MaxLength(4000)]
        public string? Description { get; set; }
        [DisplayName("Ürün Açıklama Önizlemesi")]
        public string? Preview { get; set; }
        [DisplayName("Ürün Özellikleri")]
        [MaxLength(4000)]
        public string? Features { get; set; }
        [DisplayName("Kategori Numarası")]
        public int? CategoryId { get; set; }
        [DisplayName("Ürün Stok Numarası ")]
        [MaxLength(8), MinLength(8)]
        public string ProductNumber { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public decimal? UnitPrice { get; set; }
        [DisplayName("Ürün Stok")]
        public short? UnitsInStock { get; set; }
        [DisplayName("Ürün Fotoğrafı")]
        [Column(TypeName = "Picture")]
        public IFormFile Photo { get; set; }
    }
}
