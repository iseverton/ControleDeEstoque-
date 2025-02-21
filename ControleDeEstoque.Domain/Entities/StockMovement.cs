using ControleDeEstoque.Domain.Entities.Shared;
using ControleDeEstoque.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities;

public class StockMovement 
{
    // é criado quando retirar um adicionar um produto
    public int Id { get; private set; }
    public DateTime MovementDate { get;  private set; } = DateTime.Now;
    public int Quantity { get; private set; }

    public StockMovementType Type { get; private set; }

    public int ResponsibleUser { get; private set; }
    public User User { get; private set; } // 1-N

    public int ProductId { get; private set; }
    public Product Product { get; private set; } // 1-N


}
