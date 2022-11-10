using DataAccess.Entities;
using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Concrete
{
    public class SalesManager : BaseSalesManager
    {
        public override void Sale(Game game, Gamer gamer)
        {
            base.Sale(game, gamer);
        }
    }
}
