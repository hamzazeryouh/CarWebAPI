using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CarWebAPI.Entities.Domain;
using CarWebAPI.Modules;
using CarWebAPI.Services.BaseService;
using Microsoft.AspNetCore.Mvc;

public class BaseController<T, TResponse> : ControllerBase where T : class
{
    private readonly IBaseService<T, TResponse> _service;

    public BaseController(IBaseService<T, TResponse> service)
    {
        _service = service ?? throw new ArgumentNullException(nameof(service));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BaseResponse<TResponse>>> GetById(object id)
    {
        var result = await _service.GetByIdAsync(id);
        if (result.Success)
        {
            return Ok(result);
        }
        else
        {
            return NotFound(result);
        }
    }

    [HttpGet("GetPaginate")]
    public async Task<ActionResult<BaseResponse<IEnumerable<TResponse>>>> GetPaginatedAndFilteredData(int pageNumber, int pageSize)
    {
        // Assuming you have a data repository or service
        var data =await _service.GetPaginatedAndFilteredData(pageNumber, pageSize, null);
        return Ok(data);
    }


    [HttpGet]
    public async Task<ActionResult<BaseResponse<IEnumerable<TResponse>>>> GetAll()
    {
        var result = await _service.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponse<TResponse>>> Create([FromBody] T entity)
    {
        var result = await _service.CreateAsync(entity);
        return CreatedAtAction(nameof(GetById), new { id = result.Value }, result);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<BaseResponse<TResponse>>> Update([FromRoute] object id, [FromBody] T entity)
    {
        var result = await _service.UpdateAsync(id, entity);
        if (result.Success)
        {
            return Ok(result);
        }
        else
        {
            return NotFound(result);
        }
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<BaseResponse<bool>>> Delete(object id)
    {
        var result = await _service.DeleteAsync(id);
        if (result.Success)
        {
            return Ok(result);
        }
        else
        {
            return NotFound(result);
        }
    }
}
