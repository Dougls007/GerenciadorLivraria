using GerenciadorLivraria.Communication.Requests;
using GerenciadorLivraria.Communication.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GerenciadorLivraria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManageBooksController : ControllerBase
    {
        private static List<ResponseRegisteredBookJson> books = new List<ResponseRegisteredBookJson>();

        [HttpPost("register-book")]
        [ProducesResponseType(typeof(ResponseRegisteredBookJson), StatusCodes.Status201Created)]
        public IActionResult RegisterBook([FromBody] RequestRegisterBookJson request)
        {
            var response = new ResponseRegisteredBookJson() { Id = request.Id, Titulo = request.Titulo };
            books.Add(response);
            return Created(string.Empty, response);
        }

        [HttpPut("update-book/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestUpdateBookJson request)
        {
            return NoContent();
        }

        [HttpDelete("delete-book/{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteBook([FromRoute] int id) => NoContent();

        [HttpGet("get-all-books")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetAllBooks() => Ok(books);
    }
}
