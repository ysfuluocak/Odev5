using DataAccess.Entities;
using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Concrete
{
    public class CheckIfPersonReal : BaseCheckIfPerson
    {
        public override bool CheckIfPerson(Gamer gamer)
        {
            if (gamer.Age>=18)
            {
                return true;
            }
            else
                return false;
            
        }
       
    }
}
