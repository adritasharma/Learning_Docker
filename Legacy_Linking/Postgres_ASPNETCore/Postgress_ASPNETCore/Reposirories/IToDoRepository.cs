using Postgress_ASPNETCore.Db.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Postgress_ASPNETCore.Reposirories
{
    public interface IToDoRepository
    {
        public IEnumerable<ToDo> GetAllToDos();
    }
}
