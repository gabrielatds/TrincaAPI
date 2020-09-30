using ChurrasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Adapter
{
    public interface IChurrascoAdapter
    {
        /// <summary>
        /// Obtém a lista de todos os churrascos
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Churrasco>> GetAllChurrascos();

        /// <summary>
        /// Obtém um churrasco pelo ID
        /// </summary>
        /// <returns></returns>
        Task<Churrasco> GetChurrascoById(int id);
    }
}
