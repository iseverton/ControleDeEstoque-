using ControleDeEstoque.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities;

public class StockMovement 
{
    public int Id { get; private set; }
    public DateTime MovementDate { get;  private set; } = DateTime.Now;
    public int ProductId { get; private set; }
    public int Quantity { get; private set; }
    public int ResponsibleUser { get; private set; }
    public StockMovementType Type { get; private set; }
}
