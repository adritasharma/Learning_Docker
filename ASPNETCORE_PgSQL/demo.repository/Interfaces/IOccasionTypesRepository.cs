using Demo.db.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace demo.repository.Interfaces
{
    public interface IOccasionTypesRepository
    {
        public IEnumerable<OccasionType> GetAllOccasionTypes();
    }
}
