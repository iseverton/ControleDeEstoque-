using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using ControleDeEstoque.infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.infrastructure.Repositories;

public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    private readonly AppDbContext _context;

    public CategoryRepository(AppDbContext context) : base(context)
    {
    }
}
