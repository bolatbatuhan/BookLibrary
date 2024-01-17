using Business.Abstract;
using Entities.DTOs.RequestDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PublishersController : ControllerBase
{
    IPublisherService _publisherService;

    public PublishersController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        var result = _publisherService.GetAll();
        if (result.Success)
        {
            return Ok(result.Data);
        }
        return BadRequest(result.Message);
    }
    [HttpGet("getbyid")]
    public IActionResult GetById(int id)
    {
        var result = _publisherService.GetById(id);
        if(result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("add")]
    public IActionResult Add(PublisherAddRequest publisherAddRequest)
    {
        var result = _publisherService.Add(publisherAddRequest);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);

    }
    [HttpPost("delete")]
    public IActionResult Delete(int publisherId)
    {
        var result = _publisherService.Delete(publisherId);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }
    [HttpPost("update")]
    public IActionResult Update(PublisherUpdateRequest publisherUpdateRequest)
    {
        var result = _publisherService.Update(publisherUpdateRequest);
        if (result.Success)
        {
            return Ok(result);
        }
        return BadRequest(result.Message);
    }

}
