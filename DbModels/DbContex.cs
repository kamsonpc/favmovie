using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace favmovie.DbModels
{
    public class DatabaseContex : DbContext 
    {
        public DatabaseContex(DbContextOptions<DatabaseContex> options)
                :base(options)
        {
        
        }
        public DbSet<Movie> Movie { get; set; }

    }

}
