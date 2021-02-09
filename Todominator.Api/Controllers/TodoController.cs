using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Todominator.Core.Domain;
using Todominator.Core.Service;

namespace Todominator.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ITodoService _service;

        public TodoController(ITodoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> ListAsync()
        {
            try
            {
                var todos = await _service.GetTodoListAsync();
                return Ok(todos);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromRoute] TodoEntry todo)
        {
            try
            {
                var addedTodo = await _service.AddTodoAsync(todo);
                return Ok(addedTodo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPatch]
        [Route("done/{todoId}")]
        public async Task<IActionResult> SetDoneAsync([FromBody] long todoId)
        {
            try
            {
                var doneTodo = await _service.SetTodoDoneAsync(todoId);
                return Ok(doneTodo);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
