using ControleDeEstoque.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; }
    public string BarCode { get; private set; }
    public Decimal Price { get; private set; }
    public int CurrentStock { get; private set; }
    public int MinimumStock { get; private set; }
    public DateTime ExpirationDate { get; private set; }
    public bool IsActive { get; private set; } = true;
    public int CategoryProductId { get; private set; }
    public CategoryProduct Category { get; private set; }
    public int SupplierId { get; private set; }
    public Supplier Supplier { get; private set; }

    public Product(string name, string barCode, Decimal price, int currentStock, int minimumStock, DateTime expirationDate, int categoryProductId, int supplierId)
    {
        Name = name;
        BarCode = barCode;
        Price = price;
        CurrentStock = currentStock;
        MinimumStock = minimumStock;
        ExpirationDate = expirationDate;
        CategoryProductId = categoryProductId;
        SupplierId = supplierId;
    }


}
