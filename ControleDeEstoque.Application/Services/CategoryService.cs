using AutoMapper;
using ControleDeEstoque.Application.DTOs.CategoryDTOs;
using ControleDeEstoque.Application.DTOs.Validations.CategoryDTOsValidations;
using ControleDeEstoque.Application.Interfaces;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.Domain.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace ControleDeEstoque.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper ;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }


        public async Task<int> AddCategoryAsync(CategoryCreateDTO categoryCreateDTO)
        {
            
                // validation input
                var result = await new CategoryCreateDTOValidation().ValidateAsync(categoryCreateDTO);
                if (!result.IsValid) throw new ValidationException(result.Errors);

                // auto mapper
                //var model = new Category(categoryCreateDTO.Name, categoryCreateDTO.Description);
                var model = _mapper.Map<Category>(categoryCreateDTO);

                await _categoryRepository.AddAsync(model);
                return model.Id;
            
            
        }


        public async Task<Category> GetById(int id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            return result;
        }
    }
}
