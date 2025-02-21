using ControleDeEstoque.Application.DTOs.CategoryDTOs;
using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<int> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO);
        Task<Category> GetById(int id);
    }
}
