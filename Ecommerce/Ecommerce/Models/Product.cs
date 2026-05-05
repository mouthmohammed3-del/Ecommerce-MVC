using System;
using System.Collections.Generic;

namespace Ecommerce.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public int? Catid { get; set; }

    public string? Photo { get; set; }

    public virtual ICollection<Cart> Carts { get; } = new List<Cart>();

    public virtual Category? Cat { get; set; }
}
