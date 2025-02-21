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

    public ICollection<Category> Categories { get; private set; } // M-N

    public int SupplierId { get; private set; }
    public Supplier Supplier { get; private set; } // 1-N

    public ICollection<StockMovement> StockMovements { get; private set; } // 1-N
    public ICollection<LowStockWarnings> LowStockWarnings { get; private set; } // 1-N

}
