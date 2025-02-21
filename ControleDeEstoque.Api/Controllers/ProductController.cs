using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProductController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var products = await _context.Products.ToListAsync();
        return Ok(products);
    }
    [HttpPost]
    public async Task<IActionResult> Create(Product product)
    {
        _context.Products.Add(product);
        await _context.SaveChangesAsync();
        return Ok(product);
    }
}
