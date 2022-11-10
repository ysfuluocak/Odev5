using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Game :IEntity
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public string Description { get; set; }

    }
}
