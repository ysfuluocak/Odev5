using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    public interface ISalesService
    {
        void Sale(Game game, Gamer gamer);
    }
}
