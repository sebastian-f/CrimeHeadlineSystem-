using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem
{
    public class CrimeSystem : AbstractCrimeSystem
    {
        ScreenScraperPolisen screenScraperPolisen;
        ScreenScraperUtryckning screenScraperUtryckning;


        public void RegisterPolisen(ScreenScraperPolisen screenScraperPolisen)
        {
            this.screenScraperPolisen = screenScraperPolisen;
        }

        public void RegisterUtryckning(ScreenScraperUtryckning screenScraperutryckning)
        {
            this.screenScraperUtryckning = screenScraperutryckning;
        }
    }
}
