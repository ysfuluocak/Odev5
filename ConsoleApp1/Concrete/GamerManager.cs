using DataAccess.Abstract;
using DataAccess.Entities;
using Demo.Abstract;
using Demo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GamerManager : EntityBaseManager
    {
        List<Gamer> gamers;
        ICheckIfPerson _checkIfPerson;
        public GamerManager(ICheckIfPerson checkIfPerson)
        {
            _checkIfPerson = checkIfPerson;
            gamers = new List<Gamer>();
        }
        public override void Add(IEntity gamer)
        {
            
            if (_checkIfPerson.CheckIfPerson((Gamer)gamer))
            {
                gamers.Add((Gamer)gamer);
            }
            else
                Console.WriteLine("Reşit değilsiniz...");
            
        }

        public override void Delete(IEntity gamer)
        {
            var result = gamers.FirstOrDefault(g => g.Id == ((Gamer)gamer).Id);
            gamers.Remove(result);
        }

        public override void GetAll()
        {
            gamers.ForEach(g => Console.WriteLine($"{g.FirstName},{g.LastName}"));
        }

        public override void Update(IEntity gamer)
        {
            var result = gamers.FirstOrDefault(g => g.Id == ((Gamer)gamer).Id);
            result.FirstName = ((Gamer)gamer).FirstName;
            result.LastName = ((Gamer)gamer).LastName;
            result.Age = ((Gamer)gamer).Age;
        }
    }
}
