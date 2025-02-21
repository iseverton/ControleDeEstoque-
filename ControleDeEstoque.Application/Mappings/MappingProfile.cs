using AutoMapper;
using ControleDeEstoque.Application.DTOs.CategoryDTOs;
using ControleDeEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeEstoque.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category,CategoryCreateDTO>().ReverseMap(); 
        }
    }
}
