using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public abstract class EntityBaseManager : IEntityBaseService
    {
        public abstract void Add(IEntity entity);
        public abstract void Delete(IEntity entity);
        public abstract void GetAll();
        public abstract void Update(IEntity entity);
    }
}
