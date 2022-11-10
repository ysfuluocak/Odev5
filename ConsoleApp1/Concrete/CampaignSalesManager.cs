using DataAccess.Entities;
using Demo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Concrete
{
    public class CampaignSalesManager : BaseSalesManager
    {
        Campaign _campaign;
        public CampaignSalesManager(Campaign campaign)
        {
            _campaign = campaign;
        }

        public override void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine($"{gamer.FirstName}, {game.GameName} adlı oyunu %{_campaign.CampaignPercent} indirimle {game.Price*(1-(_campaign.CampaignPercent/100))} tl ye  satın aldı.");
        }
    }
}
