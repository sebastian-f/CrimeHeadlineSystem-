using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem
{
    public class ScreenScraperPolisen : IScreenScraper
    {
        CrimeSystem crimeSystem = new CrimeSystem();
        string site;

        public ScreenScraperPolisen(CrimeSystem crimeSystem)
        {
            this.crimeSystem = crimeSystem;
            crimeSystem.RegisterPolisen(this);
            site = "Polisen";
        }

        public void ReadTopCrime()
        {
            string address = "http://polisen.se/Stockholms_lan/";
            var web = new HtmlAgilityPack.HtmlWeb();
            var doc = web.Load(address);

            string title;
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//*[@id='newslist-1']/div/ul/li[1]/p[1]/a");
            title = (node.InnerText);

            crimeSystem.FoundCrime(site, title);
        }
    }
}
