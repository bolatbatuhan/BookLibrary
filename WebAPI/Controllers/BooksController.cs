using Business.Abstract;
using CorePackages.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BooksController : ControllerBase
{
    IBookService _bookService;

    public BooksController(IBookService bookService)
    {
        _bookService = bookService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _bookService.GetAll();
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _bookService.GetById(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
    [HttpGet("getbyprice")]
    public IActionResult GetByPrice(double min, double max)
    {
        var result = _bookService.GetByPrice(min, max);
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }
    [HttpGet("getdetails")]
    public IActionResult GetDetails()
    {
        var result = _bookService.GetDetail();
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }

    [HttpPost("add")]
    public IActionResult Add(BookAddRequest bookAddRequest)
    {
        var result = _bookService.Add(bookAddRequest);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
    [HttpPost("delete")]
    public IActionResult Delete(int bookId)
    {
        var result = _bookService.Delete(bookId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }

    [HttpPost("update")]
    public IActionResult Update(BookUpdateRequest bookUpdateRequest)
    {
        var result = _bookService.Update(bookUpdateRequest);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result);
    }
}
