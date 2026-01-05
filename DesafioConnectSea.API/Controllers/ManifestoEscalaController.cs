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
    public class ManifestoEscalaController : ControllerBase
    {
        private readonly IManifestoEscalaService _service;
        private readonly IMapper _mapper;
        public ManifestoEscalaController(IManifestoEscalaService service, IMapper mapper)
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
        public async Task<IActionResult> Post([FromBody] ManifestoEscalaInputModel input)
        {
            try
            {
                var id = await _service.AddAsync(_mapper.Map<ManifestoEscala>(input));

                return CreatedAtAction(nameof(Get), new { id = id }, input);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
