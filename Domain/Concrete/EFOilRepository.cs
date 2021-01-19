using Domain.Abstract;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Concrete
{
   public class EFOilRepository : IOilRepository
    {
        EFDbContext context = new EFDbContext();
        public IEnumerable<Oil> Oils
        {
            get { return context.Oils; }
        }
    }
}
