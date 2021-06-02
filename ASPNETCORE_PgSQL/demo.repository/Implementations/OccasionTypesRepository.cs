using demo.repository.Interfaces;
using Demo.db;
using Demo.db.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace demo.repository.Implementations
{
    public class OccasionTypesRepository : IOccasionTypesRepository
    {
        protected AnniversaryContext _context;
        protected DbSet<OccasionType> DbSet;
        public OccasionTypesRepository(AnniversaryContext context) 
        {
            _context = context;
            DbSet = _context.Set<OccasionType>();
        }
        public IEnumerable<OccasionType> GetAllOccasionTypes()
        {
            return DbSet.AsEnumerable<OccasionType>();
        }
    }
}
