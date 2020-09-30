using ChurrasAPI.Dtos;
using ChurrasAPI.Interfaces;
using ChurrasAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Controllers
{
    public class ParticipantesController : Controller
    {
        private readonly IParticipanteService _participanteService;

        public ParticipantesController(IParticipanteService participanteService)
        {
            _participanteService = participanteService;
        }


        
        /// <summary>
        /// Adiciona um participante a um churrasco
        /// </summary>
        /// <param name="id"></param>
        /// <param name="participantePost"></param>
        /// <returns></returns>
        [HttpPost("novo/{id}")]
        public async Task<IActionResult> AdicionarParticipante(int? id, [FromBody] ParticipantePost participantePost)
        {
            var participante = new Participante
            {
                Nome = participantePost.Nome,
                Contribuicao = participantePost.Contribuicao,
                Pago = participantePost.Pago,
                ChurrascoId = id.Value,
            };
            await _participanteService.InsertAsync(participante);
            return Ok("participante adicionado");
        }

        /// <summary>
        /// Remove um participante pelo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("remover/{id}")]
        public async Task<IActionResult> RemoverParticipante(int? id)
        {
            await _participanteService.RemoveAsync(id.Value);
            return Ok("Participante Removido");
        }

        /// <summary>
        /// Edita se o participante pagou ou não
        /// </summary>
        /// <param name="id"></param>
        /// <param name="participantePago"></param>
        /// <returns></returns>
        [HttpPatch("{id}/pago")]
        public async Task<IActionResult> PagamentoParticipante(int? id, ParticipantePago  participantePago)
        {
            await _participanteService.UpdateAsync(id.Value, participantePago);
            return Ok();
        }
    }
}