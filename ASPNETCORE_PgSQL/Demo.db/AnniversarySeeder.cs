using Demo.db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.SqlServer;

namespace Demo.db
{
    public class AnniversarySeeder
    {
        private readonly AnniversaryContext _db;

        public AnniversarySeeder(AnniversaryContext db)
        {
            _db = db;
        }

        public async Task Seed()
        {
            _db.Database.Migrate();

            if (!_db.OccasionTypes.Any())
            {
                _db.OccasionTypes.Add(new OccasionType
                {
                    OccasionTypeName = "BirthDay",
                });
                _db.OccasionTypes.Add(new OccasionType
                {
                    OccasionTypeName = "Marriage Anniversary",
                });
                _db.OccasionTypes.Add(new OccasionType
                {
                    OccasionTypeName = "Death Anniversary",
                });
                _db.SaveChanges();
            }
        }
    }
}
