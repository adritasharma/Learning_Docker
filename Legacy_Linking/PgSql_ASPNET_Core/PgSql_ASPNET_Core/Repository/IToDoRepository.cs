using PgSql_ASPNET_Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PgSql_ASPNET_Core.Repository
{
    public interface IToDoRepository
    {
        public IEnumerable<ToDo> GetAllToDos();
    }
}
