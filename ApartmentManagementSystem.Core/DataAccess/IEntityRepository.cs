using ApartmentManagementSystem.Core.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace ApartmentManagementSystem.Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity,new() 
    {
       
    }
}
