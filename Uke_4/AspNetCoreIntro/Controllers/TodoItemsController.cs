using System.Net;
using AspNetCoreIntro.Extensions;
using AspNetCoreIntro.Models.Dto;
using AspNetCoreIntro.Models.Entities;
using AspNetCoreIntro.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreIntro.Controllers;


[Route("api/[controller]")] //Hva vil endepunktet vårt bli her? api/TodoItems
[ApiController]
public class TodoItemsController(TodoItemRepository repository) : ControllerBase
{
    [HttpGet]
    public IActionResult Get(TodoItemQueryDto? dto)=> Ok(dto is not null ? dto.Query(repository) : repository.Get());

    [HttpGet("{id:guid}")]
    public IActionResult Get(Guid id) => Ok(repository.Get(id));

    [HttpPost]
    [ProducesResponseType((int)HttpStatusCode.Created)]
    [ProducesResponseType((int)HttpStatusCode.BadRequest)]
    public IActionResult Post([FromBody] CreateTodoItemDto dto)
    {
        try
        {
            var result = repository.AddItem(dto);
            return Created($"api/todoitem/{result.Id}", result);
        } catch (ArgumentNullException ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("{id:Guid}")]
    [ProducesResponseType((int)HttpStatusCode.NoContent)]
    public IActionResult Delete(Guid id)
    {
        repository.Delete(id);
        return NoContent();
    }

    [HttpPut]
    [ProducesResponseType((int)HttpStatusCode.Created)]
    public IActionResult Put(TodoItem item) => Created($"api/todoitem/{item.Id}", repository.Put(item));
}
