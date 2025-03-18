using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using devopsVinicius.Models;

namespace devopsVinicius.Data
{
    public class devopsViniciusContext : DbContext
    {
        public devopsViniciusContext (DbContextOptions<devopsViniciusContext> options)
            : base(options)
        {
        }

        public DbSet<devopsVinicius.Models.Aluno> Aluno { get; set; } = default!;
    }
}
