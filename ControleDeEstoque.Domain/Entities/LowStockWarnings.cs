using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities;

public class LowStockWarnings
{
    public int Id { get; private set; } 
    public DateTime CreatedAt { get; private set; }

    public int ProductId { get; private set; }
    public Product Product { get; private set; } // 1-N
}
