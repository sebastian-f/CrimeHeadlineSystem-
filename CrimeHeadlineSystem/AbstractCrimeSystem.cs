using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrimeHeadlineSystem
{
    public abstract class AbstractCrimeSystem
    {
        public void FoundCrime(string site, string title)
        {
            Console.WriteLine(site + " " + title);
        }
    }
}
