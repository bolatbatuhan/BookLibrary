using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _categoryService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(CategoryAddRequest categoryAddRequest)
        {
            var result = _categoryService.Add(categoryAddRequest);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int categoryId)
        {
            var result = _categoryService.Delete(categoryId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CategoryUpdateRequest categoryUpdateRequest)
        {
            var result = _categoryService.Update(categoryUpdateRequest);
            if (result.Success)
            {
                return Ok(result);
            }
                return BadRequest(result);
        }


    }
}
