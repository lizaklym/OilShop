using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Oil> Oils { get; set; }
    }
}
