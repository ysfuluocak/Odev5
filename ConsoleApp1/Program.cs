using DataAccess.Concrete;
using DataAccess.Entities;
using Demo.Concrete;

Game game = new Game() { Id = 1, GameName = "Metin2", Description = "MMORPG", InStock = 100, Price = 100 };
Game game1 = new Game() { Id = 2, GameName = "LoL", Description = "MOBA", InStock = 90, Price = 50 };
Game game2 = new Game() { Id = 3, GameName = "CsGo", Description = "FPS", InStock = 80, Price = 25 };

GameManager gameDal = new GameManager();
gameDal.Add(game);
gameDal.Add(game1);
gameDal.Add(game2);

List<Gamer> gamers = new List<Gamer>()
{ new Gamer{ Id=1, FirstName="Yusuf",LastName="Yusuf",Age=28, NationalityId="1234567890"},
new Gamer{ Id=2,FirstName="Ziya", LastName="Ziya",Age=24, NationalityId="74125896312"},
new Gamer{ Id=3,FirstName="Ömer", LastName="Ömer",Age=27, NationalityId="5453215747"},
};

GamerManager gamerManager = new GamerManager(new CheckIfPersonFake());
foreach (var gamer in gamers)
{
    gamerManager.Add(gamer);
}

Campaign campaign = new Campaign() { Id = 1, CampaignName = "BlackFriday", CampaignPercent = 10 };
Campaign campaign2 = new Campaign() { Id = 2, CampaignName = "SüperCuma,", CampaignPercent = 50 };

CampaignManager campaignManager = new CampaignManager();
campaignManager.Add(campaign);
campaignManager.Add(campaign2);

SalesManager salesManager = new SalesManager();
salesManager.Sale(game, gamers.FirstOrDefault(g => g.Id == 1));
salesManager.Sale(game1, gamers.FirstOrDefault(g => g.Id == 2));
CampaignSalesManager campaignSalesManager = new CampaignSalesManager(campaign2);
campaignSalesManager.Sale(game2, gamers.Find(g => g.Id == 3));

Console.ReadLine();






