using AutoMapper;
using BasGelsin.Business.Concrete;
using BasGelsin.Core.DTOs.Category;
using BasGelsin.DataAccsess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using BasGelsin.Data.Concrete;

namespace BasGelsin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryManager _categoryManager;
        private readonly Context _context;
        private readonly IMapper _mapper;

        public CategoryController(CategoryManager categoryManager, Context context, IMapper mapper)
        {
            _categoryManager = categoryManager;
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _categoryManager.GetAllCategories();
            return Ok(values);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory(AddCategoryDTO addCategoryDTO)
        {
            var category = new Category
            {
                Name = addCategoryDTO.Name,
                SubId = addCategoryDTO.SubId,
                CompanyId = addCategoryDTO.CompanyId
            };

            _categoryManager.CategoryAdd(category);

            return Ok(_mapper.Map<CategoryDTO>(category));
        }

        [HttpGet("ShowCategories")]
        public async Task<IActionResult> ShowCategories(int companyId)
        {
            var allCategories = await _context.Categories
                .Where(c => c.CompanyId == companyId)
                .Include(p => p.Product)
                .ToListAsync();

            var hierarchicalCategories = BuildCategoryHierarchy(allCategories, null);

            return Ok(hierarchicalCategories);
        }

        private List<CategoryDTO> BuildCategoryHierarchy(List<Category> categories, int? parentId)
        {
            var result = new List<CategoryDTO>();
            foreach (var category in categories.Where(c => c.SubId == parentId))
            {
                var dto = _mapper.Map<CategoryDTO>(category);
                dto.Subcategories = BuildCategoryHierarchy(categories, category.Id);
                result.Add(dto);
            }
            return result;
        }
    }
}
