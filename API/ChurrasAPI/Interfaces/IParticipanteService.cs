using ChurrasAPI.Dtos;
using ChurrasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Interfaces
{
    public interface IParticipanteService
    {
        /// <summary>
        /// Retorna todos os participantes do banco de dados ordenados pelo nome
        /// </summary>
        /// <returns></returns>
        Task<List<Participante>> FindAllAsync();

        /// <summary>
        /// Retorna um participantes pelo seu ID no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Participante> FindByIdAsync(int id);


        /// <summary>
        /// Insere um novo participante no banco de dados
        /// </summary>
        /// <param name="churrasco"></param>
        /// <returns></returns>
        Task InsertAsync(Participante participante);

        /// <summary>
        /// Remove um participante do banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveAsync(int id);

        /// <summary>
        /// Atualiza um participante no banco de dados
        /// </summary>
        /// <param name="churrasco"></param>
        /// <returns></returns>
        Task UpdateAsync(int id, ParticipantePago participantePago);
    }
}
