using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WA_EShop.Models.DB;

public partial class Categories
{
    [DisplayName("Kategori Numarası")]
    [Key]
    public int CategoryId { get; set; }

    [DisplayName("Kategori Adı")]
    public string CategoryName { get; set; } = null!;

    [DisplayName("Kategori Açıklaması")]
    public string? Description { get; set; }
}
