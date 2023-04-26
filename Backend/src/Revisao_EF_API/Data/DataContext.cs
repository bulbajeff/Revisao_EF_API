using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RevisaoEF.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}