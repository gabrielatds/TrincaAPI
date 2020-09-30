using ChurrasAPI.Dtos;
using ChurrasAPI.Interfaces;
using ChurrasAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Threading.Tasks;

namespace ChurrasAPI.Controllers
{

    public class ChurrascosController : Controller
    {
        private readonly IChurrascoService _churrascoService;
        public ChurrascosController(IChurrascoService churrascoService, IParticipanteService participanteService)
        {
            _churrascoService = churrascoService;
        }

        /// <summary>
        /// Retorna lista de todos os churrascos cadastrados
        /// </summary>
        /// <returns>Retorna lista de todos churrascos</returns>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>

        [HttpGet()]
        public async Task<IActionResult> FindAll()
        {
            try
            {
                var churrascos = await _churrascoService.FindAllAsync();
                return Ok(churrascos);
            }
            catch
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Retorna um churrasco pelo ID
        /// </summary>
        /// <returns>Retorna um churrasco</returns>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>

        [HttpGet("{id}")]
        public async Task<IActionResult> FindChurrasco(int? id)
        {
            var churrasco = await _churrascoService.FindByIdAsync(id.Value);
            return Ok(churrasco);
        }

        /// <summary>
        /// Insere um novo churrasco no banco de dados
        /// </summary>
        /// <response code="201">Sucesso</response>
        /// <response code="500">Erro interno</response>

        [HttpPost("novo")]
        public async Task<IActionResult> Create(ChurrascoPost churrascoPost)
        {
            await _churrascoService.InsertAsync(churrascoPost);
            return Ok("Churrasco Criado");
        }

        /// <summary>
        /// Atualiza os dados de um churrasco no banco de dados
        /// </summary>
        /// <returns>Atualiza um churrasco</returns>
        /// <response code="204"> Sucesso</response>
        /// <response code="500">Erro interno</response>

        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            var churrasco = await _churrascoService.FindByIdAsync(id.Value);
            return Ok(churrasco);
        }

        /// <summary>
        /// Remove um churrasco do banco de dados
        /// </summary>
        /// <response code="204">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {

            await _churrascoService.RemoveAsync(id.Value);
            return Ok("Churrasco removido");
        }

        /// <summary>
        /// Adiciona um participante ao churrasco
        /// </summary>
        /// <param name="id"></param>
        /// <param name="participantePost"></param>
        /// <returns></returns>
    }
}
