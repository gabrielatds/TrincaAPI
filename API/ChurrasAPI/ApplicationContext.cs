using ChurrasAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurrasAPI
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Churrasco> Churrascos { get; set; }
        public DbSet<Participante> Participantes { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> opcoes) : base(opcoes)
        {
        }
    }
}
