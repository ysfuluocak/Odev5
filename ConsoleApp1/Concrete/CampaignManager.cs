using DataAccess.Abstract;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CampaignManager : EntityBaseManager
    {
        List<Campaign> campaigns;
        public CampaignManager()
        {
            campaigns = new List<Campaign>();
        }

        public override void Add(IEntity campaign)
        {
            campaigns.Add((Campaign)campaign);
        }

        public override void Delete(IEntity campaign)
        {
           var result = campaigns.FirstOrDefault(c => c.Id == ((Campaign)campaign).Id);
           campaigns.Remove(result);
        }

        public override void GetAll()
        {
            campaigns.ForEach(c => Console.WriteLine($"{c.CampaignName},{c.CampaignPercent}"));
        }

        public override void Update(IEntity campaign)
        {
            var result = campaigns.FirstOrDefault(c=>c.Id== ((Campaign)campaign).Id);
            result.CampaignName = ((Campaign)campaign).CampaignName;
            result.CampaignPercent = ((Campaign)campaign).CampaignPercent;
        }
    }
}
