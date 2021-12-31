using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecodeMvc.Models
{
    public class TradutorContext : DbContext
    {
        public TradutorContext()
        {

        }

        public TradutorContext(DbContextOptions<TradutorContext> options) : base(options)
        {

        }

        public DbSet<Tradutor> Tradutores { get; set; }
    }
}
