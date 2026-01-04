using AutoMapper;
using DesafioConnectSea.Application.InputModels;
using DesafioConnectSea.Application.ViewModels;
using DesafioConnectSea.Domain.Entities;
using DesafioConnectSea.Domain.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace DesafioConnectSea.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ManifestoController : ControllerBase
    {
        private readonly IManifestoService _service;
        private readonly IMapper _mapper;
        public ManifestoController(IManifestoService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _service.GetAllAsync();
            return Ok(_mapper.Map<List<ManifestoViewModel>>(result));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ManifestoInputModel input)
        {
            var id = await _service.AddAsync(_mapper.Map<Manifesto>(input));

            return CreatedAtAction(nameof(Get), new { id = id }, input);
        }
    }
}
