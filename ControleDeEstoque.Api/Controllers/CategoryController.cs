using ControleDeEstoque.Application.DTOs.CategoryDTOs;
using ControleDeEstoque.Application.Interfaces;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.infrastructure.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleDeEstoque.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{

    private readonly ICategoryService _categoryService;
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var result = await _categoryService.GetById(id);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]  
    public async Task<IActionResult> Create(CategoryCreateDTO categoryCreateDTO)
    {
        try
        {
            var result = await _categoryService.AddCategoryAsync(categoryCreateDTO);
            return CreatedAtAction(nameof(GetById), new { id = result }, categoryCreateDTO);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
  
}
