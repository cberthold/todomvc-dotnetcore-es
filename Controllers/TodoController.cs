using Microsoft.AspNetCore.Mvc;
using DotNetTodoList.Models;
using System.Collections.Generic;

namespace DotNetTodoList.Controllers
{
  [Route("api/[controller]")]
  public class TodoController : Controller
  {
    private readonly Todo _todo;
    public TodoController(TodoContext context)
    {
      _todo = new Todo(context);
    }
    
    [HttpGet]
    public IEnumerable<Todo> GetAll()
    {
      return _todo.GetALl();
    }

    [HttpPost]
    public IActionResult Create([FromBody] Todo item)
    {
      if (item == null) return BadRequest();

      _todo.Add(item);

      return Created($"api/todo/{item.Id}", item);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      if (_todo.GetItem(id) == null) return NotFound();

      _todo.Remove(id);
      return new NoContentResult();
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Todo item)
    {
      if (item == null || item.Id != id) return BadRequest();

      var task = _todo.GetItem(id);
      if (task == null) return NotFound();

      task.isComplete = item.isComplete;
      task.Name = item.Name;

      _todo.Update(task);
      return new NoContentResult();
    }
  }
}
