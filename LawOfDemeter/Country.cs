using System;
using System.Collections.Generic;
using System.Text;

namespace LawOfDemeter
{
    public class Country
    {

        private bool inEurope = false;

        public Country(bool inEurope)
        {
            this.inEurope = inEurope;
        }

        public bool IsInEurope
        {
            get { return inEurope; }
        }

    }

}
