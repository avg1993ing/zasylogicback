using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _clienteService;
        public readonly IMapper _mapper;
        public ClienteController(IClienteService clienteService, IMapper mapper) {
            _clienteService = clienteService;
            _mapper = mapper;   
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll(DateTime? fecha)
        {
            return Ok(_mapper.Map<List<ClienteDto>>(await _clienteService.GetAll(fecha)));
        }

        [HttpGet]
        [Route("Motivo")]
        public async Task<IActionResult> GetAllMotivo()
        {
            return Ok(_mapper.Map<List<MotivoDto>>(await _clienteService.GetAllMotivo()));
        }

        [HttpPost]
        public async Task<IActionResult> AddCliente(ClienteDto cliente)
        {
            return Ok(_mapper.Map<ClienteDto>(await _clienteService.AddCliente(_mapper.Map<Cliente>(cliente))));
        }
    }
}
