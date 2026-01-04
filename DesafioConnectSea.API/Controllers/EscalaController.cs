using AutoMapper;
using DesafioConnectSea.Application.InputModels;
using DesafioConnectSea.Application.ViewModels;
using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Interface.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DesafioConnectSea.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscalaController : ControllerBase
    {
        private readonly IEscalaService _service;
        private readonly IMapper _mapper;
        public EscalaController(IEscalaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<EscalaViewModel>>(result));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] EscalaInputModel input)
        {
            var id = await _service.AddAsync(_mapper.Map<Escala>(input));

            return CreatedAtAction(nameof(Get), new { id = id }, input);
        }
        //[HttpPut("{id}")]      
        //public async Task<IActionResult> Put(int id, [FromBody] UpdateProjectCommand command)
        //{
        //    if (command.Description.Length > 200)
        //    {
        //        return BadRequest();
        //    }

        //    await _mediator.Send(command);

        //    return NoContent();
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var command = new DeleteProjectCommand(id);
        //    await _mediator.Send(command);
        //    return NoContent();
        //}
    }
}
