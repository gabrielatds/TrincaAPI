using ChurrasAPI.Dtos;
using ChurrasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Interfaces
{
    public interface IChurrascoService
    {
        /// <summary>
        /// Retorna todos os churrascos do banco de dados ordenados pela data
        /// </summary>
        /// <returns></returns>
        Task<List<Churrasco>> FindAllAsync();

        /// <summary>
        /// Retorna um churrasco pelo seu ID no banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Churrasco> FindByIdAsync(int id);

        /// <summary>
        /// Atualiza um churrasco no banco de dados
        /// </summary>
        /// <param name="churrasco"></param>
        /// <returns></returns>
        Task UpdateAsync(Churrasco churrasco);

        /// <summary>
        /// Insere um novo churrasco no banco de dados
        /// </summary>
        /// <param name="churrasco"></param>
        /// <returns></returns>
        Task InsertAsync(ChurrascoPost churrascoPost);

        /// <summary>
        /// Remove um churrasco do banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task RemoveAsync(int id);

    }
}
