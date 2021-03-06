﻿using System.Threading.Tasks;
using Devboost.DependecyInjection.Domain.Interface.DomainService;
using Microsoft.AspNetCore.Mvc;

namespace Devboost.DependecyInjection.API.Controllers
{
    [Route("v1/cliente")]
    [ApiController]
    public class ClienteController : Controller
    {
        private readonly IClienteDomainService _clienteService;

        public ClienteController(IClienteDomainService clienteService)
        {
            _clienteService = clienteService;
        }

        // GET
        [HttpGet("listar")]
        public async Task<IActionResult> Listar()
        {
            var clientes = await _clienteService.Listar();
            return Ok(clientes);
        }
    }
}