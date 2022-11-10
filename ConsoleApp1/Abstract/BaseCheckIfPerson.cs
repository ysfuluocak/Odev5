using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    public abstract class BaseCheckIfPerson : ICheckIfPerson
    {
        public virtual bool CheckIfPerson(Gamer gamer)
        {
            return true;
        }
    }
}
