using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPR
{
    public class Personoplysning
    {
        private uint First6digits;
        private uint Last4digits;
        private string CPRnr;
        private uint Fødselsår;

        public void CPR_met (uint first6digits, uint last4digits)
        {
            First6digits = first6digits;
            Last4digits = last4digits;
            CPRnr = first6digits + "-" + last4digits;
        }

        public string Udskriv_CPR_met ()
        {
            return CPRnr;
        }

        public uint Udskriv_first6digits_met ()
        {
            return First6digits;
        }

        public uint Udskriv_last4digits_met ()
        {
            return Last4digits;
        }

        public uint Udskriv_fødselsår_met ()
        {
            Fødselsår = First6digits % 100;
            switch (Last4digits)
            {
                case < 4000:
                    Fødselsår += 1900;
                    break;
   
                default:
                    Fødselsår += 2000;
                    break;

            
            }
            return Fødselsår;
        }
    }
}
