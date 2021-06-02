using demo.repository.Interfaces;
using Demo.db.Entities;
using Demo.service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.service.Implementations
{
    public class OccasionTypesService: IOccasionTypesService
    {
        private readonly IOccasionTypesRepository _occasionTypeRepository;

        public OccasionTypesService(IOccasionTypesRepository repository) 
        {
            _occasionTypeRepository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public IEnumerable<OccasionType> GetAllOccasionTypes()
        {
            return _occasionTypeRepository.GetAllOccasionTypes();
        }
    }
}
