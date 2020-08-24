using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SportsX.Models
{
    public class SportsXContext: DbContext
    {        
        public DbSet<Cliente> Clientes { get; set; }
    }
}