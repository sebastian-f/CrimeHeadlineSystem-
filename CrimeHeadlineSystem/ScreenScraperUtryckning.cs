using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem
{
    public class ScreenScraperUtryckning : IScreenScraper
    {
        CrimeSystem crimeSystem;
        string site;

        public ScreenScraperUtryckning(CrimeSystem crimeSystem)
        {
            this.crimeSystem = crimeSystem;
            crimeSystem.RegisterUtryckning(this);
            site = "Utryckning";
        }

        public void ReadTopCrime()
        {
            string address = "http://orebrotribune.se/utryckning-se/";
            var web = new HtmlAgilityPack.HtmlWeb();
            var doc = web.Load(address);

            string title;
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//*[@id='homepage']/div[1]/div[1]/h1/a");
            title = (node.InnerText);

            crimeSystem.FoundCrime(site, title);
        }
    }
}
