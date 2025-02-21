﻿using ControleDeEstoque.Domain.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Domain.Entities;

public class Category : BaseEntity
{
    public string? Name { get;private set; }
    public string Description { get; private set; }
    public ICollection<Product>? Products { get; set; }

    public Category(string name, string description)
    {
        Name = name;
        Description = description;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
