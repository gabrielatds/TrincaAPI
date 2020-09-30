using ChurrasAPI.Dtos;
using ChurrasAPI.Interfaces;
using ChurrasAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI.Services
{
    public class ParticipanteService : IParticipanteService
    {
        private readonly ApplicationContext _context;

        public ParticipanteService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Participante>> FindAllAsync()
        {
            return await _context.Participantes.OrderBy(x => x.Nome).ToListAsync();
        }

        public async Task<Participante> FindByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido");

            return await _context.Participantes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(int id, ParticipantePago participantePago)
        {
            if (participantePago == null)
                throw new ArgumentNullException("Particiante inválido");

            try
            {
                var participante = await FindByIdAsync(id);
                participante.Pago = participantePago.Pago;
                _context.Update(participante);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

        public async Task InsertAsync(Participante participante)
        {
            if (participante == null)
                throw new ArgumentException("Participante inválido");

            try
            {
                _context.Add(participante);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

        public async Task RemoveAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido");

            var participante = await FindByIdAsync(id);

            try
            {
                _context.Remove(participante);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

    }
}
