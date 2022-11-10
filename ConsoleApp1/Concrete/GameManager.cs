using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GameManager : EntityBaseManager
    {
        List<Game> games;

        public GameManager()
        {
            games = new List<Game>();
        }
        public override void Add(IEntity game)
        {
            games.Add((Game)game);
        }

        public override void Delete(IEntity game)
        {
            var result = games.FirstOrDefault(g=>g.Id== ((Game)game).Id);
            games.Remove(result);
        }

        public override void GetAll()
        {
            games.ForEach(g=>Console.WriteLine($"{g.GameName},{g.Description}"));
        }

        public override void Update(IEntity game)
        {
            var result = games.FirstOrDefault(g => g.Id == ((Game)game).Id);
            result.GameName = ((Game)game).GameName;
            result.Price = ((Game)game).Price;
            result.InStock = ((Game)game).InStock;
            result.Description = ((Game)game).Description;
        }
    }
}
