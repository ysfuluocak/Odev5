using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstract
{
    public abstract class BaseSalesManager : ISalesService
    {
        public virtual void Sale(Game game,Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName}, {game.GameName} adlı oyunu {game.Price} tl ye kampanyasız satıldı.");
        }
    }
}
