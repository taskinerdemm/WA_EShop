using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WA_EShop.Models.DB;

public class Products
{
    [DisplayName("Ürün Numarası")]
    [Key]
    public int ProductId { get; set; }
    [DisplayName("Ürün Adı")]
    public string ProductName { get; set; } = null!;
    [DisplayName("Ürün Açıklaması")]
    public string? Description { get; set; }
    [DisplayName("Ürün Açıklama Önizlemesi")]
    public string? Preview { get; set; }
    [DisplayName("Ürün Özellikleri")]
    public string? Features { get; set; }
    [DisplayName("Kategori Numarası")]
    public int? CategoryId { get; set; }
    [DisplayName("Ürün Stok Numarası ")]
    public string ProductNumber { get; set; }
    [DisplayName("Ürün Fiyatı")]
    public decimal? UnitPrice { get; set; }
    [DisplayName("Ürün Stok")]
    public short? UnitsInStock { get; set; }
    [DisplayName("Ürün Fotoğrafı")]
    [Column(TypeName ="Picture")]
    public string? Picture { get; set; }
}
