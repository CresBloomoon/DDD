using DDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Repositories
{
    public interface IAreasRepository
    {
        IReadOnlyList<AreaEntity> GetData();
    }
}
