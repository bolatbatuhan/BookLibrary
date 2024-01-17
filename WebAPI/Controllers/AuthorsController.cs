using Business.Abstract;
using Entities.DTOs.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthorsController : ControllerBase
{
    IAuthorService _authorService;

    public AuthorsController(IAuthorService authorService)
    {
        _authorService = authorService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _authorService.GetAll();
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }
    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _authorService.GetById(id);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("add")]
    public IActionResult Add(AuthorAddRequest authorAddRequest)
    {
        var result = _authorService.Add(authorAddRequest);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("delete")]
    public IActionResult Delete(int id)
    {
        var result = _authorService.Delete(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("update")]
    public IActionResult Update(AuthorUpdateRequest authorUpdateRequest)
    {
        var result = _authorService.Update(authorUpdateRequest);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
}
