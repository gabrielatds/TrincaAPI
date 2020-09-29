﻿using ChurrasAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data;
using ChurrasAPI.Interfaces;

namespace ChurrasAPI.Services
{
    public class ChurrascoService : IChurrascoService
    {
        private readonly ApplicationContext _context;

        public ChurrascoService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<Churrasco>> FindAllAsync()
        {
            return await _context.Churrascos.OrderBy(x => x.Data).ToListAsync();
        }

        public async Task<Churrasco> FindByIdAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido");

            return await _context.Churrascos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task UpdateAsync(Churrasco churrasco)
        {
            if (churrasco == null)
                throw new ArgumentException("Churrasco inválido");

            try
            {
                _context.Update(churrasco);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

        public async Task InsertAsync(Churrasco churrasco)
        {
            if (churrasco == null)
                throw new ArgumentException("Churrasco inválido");

            try
            {
                _context.Add(churrasco);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

        /// <summary>
        /// Remove um churrasco do banco de dados
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task RemoveAsync(int id)
        {
            if (id <= 0)
                throw new ArgumentException("ID inválido");

            var churrasco = await FindByIdAsync(id);

            try
            {
                _context.Remove(churrasco);
                await _context.SaveChangesAsync();
            }
            catch (DBConcurrencyException e)
            {
                throw new DBConcurrencyException(e.Message);
            }
        }

    }

}
