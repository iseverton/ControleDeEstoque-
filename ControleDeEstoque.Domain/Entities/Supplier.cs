using ControleDeEstoque.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities
{
    public class Supplier: BaseEntity
    {
        public string Name { get; private set; }
        public string Document { get; private set; } // CNPJ
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string PostalCode { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string Number { get; private set; }

        public bool IsActive { get; private set; } = true;

        public ICollection<Product>? Products { get; private set; } // 1-N

    }
}
