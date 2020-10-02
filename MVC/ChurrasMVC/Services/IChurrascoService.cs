using ChurrasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Services
{
    public interface IChurrascoService
    {
        Task<IEnumerable<Churrasco>> GetAllChurrascos();

        Task<Churrasco> GetChurrascoById(int? id);
    }
}
