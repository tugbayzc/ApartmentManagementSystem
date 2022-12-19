using ApartmentManagementSystem.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.DataAccess
{
    public abstract class EntityRepositoryBase<TEntity> :IEntityRepository<TEntity> 
        where TEntity: class, IEntity,new()
    {
    }
}
