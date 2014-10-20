using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CrimeHeadlineSystem;

namespace UnitTest
{
    [TestClass]
    public class CrimeHeadlineSystemTest
    {
        [TestMethod]
        public void TestScreenScraperPolisen()
        {
            CrimeSystem crimeSystem = new CrimeSystem();
            IScreenScraper screenScraping = new ScreenScraperPolisen(crimeSystem);

            screenScraping.ReadTopCrime();

        }

        [TestMethod]
        public void TestScreenScraperUtryckning()
        {
            CrimeSystem crimeSystem = new CrimeSystem();
            IScreenScraper screenScraping = new ScreenScraperUtryckning(crimeSystem);

            screenScraping.ReadTopCrime();

        }
    }
}
