using ChurrasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Services
{
    public class SeedingService
    {
        private readonly ApplicationContext _context;

        public SeedingService(ApplicationContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Churrascos.Any() || _context.Participantes.Any())
            {
                return;
            }

            Churrasco c1 = new Churrasco(new DateTime(2020, 9, 28), "Churras de boas-vindas do Gabriel", "obs: vai ter piscina", 20, 10);
            Churrasco c2 = new Churrasco(new DateTime(2020, 10, 05), "Aniversário do Gabriel", "obs: na casa da Gabriela", 25, 15);

            Participante p1 = new Participante("Gabriel", 30, true, c1);
            Participante p2 = new Participante("Gabriel", 35, false, c2);

            _context.Churrascos.AddRange(c1, c2);
            _context.Participantes.AddRange(p1, p2);
            _context.SaveChanges();
        }
    }
}
