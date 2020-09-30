using ChurrasMVC.Adapter;
using ChurrasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasMVC.Services
{
    public class ChurrascoService : IChurrascoService
    {
        private readonly IChurrascoAdapter _churrascoAdapter;

        public ChurrascoService(IChurrascoAdapter churrascoAdapter)
        {
            _churrascoAdapter = churrascoAdapter ??
                throw new ArgumentNullException();
        }

        public async Task<IEnumerable<Churrasco>> GetAllChurrascos()
        {
            var churrascos = await _churrascoAdapter.GetAllChurrascos();
            return churrascos.Select(x => new Churrasco()
            {
                Id = x.Id,
                Data = x.Data,
                Descricao = x.Descricao,
                ObsAdicional = x.ObsAdicional,
                ValorComBebida = x.ValorComBebida,
                ValorSemBebida = x.ValorSemBebida,
                Participantes = x.Participantes,
                
            });
        }

        public async Task<Churrasco> GetChurrascoById(int? id)
        {
            return await _churrascoAdapter.GetChurrascoById(id.Value);
        }
    }
}
