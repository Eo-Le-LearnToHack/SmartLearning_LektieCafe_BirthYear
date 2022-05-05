using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPR
{
    public class Personoplysning
    {
        
        public string CPRnr { get; set; }
        //public int First6digits;  ANVENDES IKKE
        private int Last4digits;
        private int Fødselsår;

    
        private void Last2DigitsInFødselsår_met ()
        {
            int first6digits = Convert.ToInt32(CPRnr.Substring(0, 6));
            Fødselsår = first6digits % 100;
        }

        private void Last4digits_met ()
        {
            int last4digits = Convert.ToInt32(CPRnr.Substring(7, 4));
            Last4digits = last4digits;
        }

        public int Udskriv_fødselsår_met ()
        {
            Last2DigitsInFødselsår_met();
            Last4digits_met();

            if (Fødselsår >= 0 && Fødselsår <= 99 && Last4digits <= 3999 )
            {
                Fødselsår += 1900;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 36 && Last4digits >= 4000 && Last4digits <= 4999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 37 && Fødselsår <= 99 && Last4digits >= 4000 && Last4digits <= 4999)
            {
                Fødselsår += 1900;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 57 && Last4digits >= 5000 && Last4digits <= 5999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 58 && Fødselsår <= 99 && Last4digits >= 5000 && Last4digits <= 5999)
            {
                Fødselsår += 1800;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 57 && Last4digits >= 6000 && Last4digits <= 6999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 58 && Fødselsår <= 99 && Last4digits >= 6000 && Last4digits <= 6999)
            {
                Fødselsår += 1800;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 57 && Last4digits >= 7000 && Last4digits <= 7999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 58 && Fødselsår <= 99 && Last4digits >= 7000 && Last4digits <= 7999)
            {
                Fødselsår += 1800;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 57 && Last4digits >= 8000 && Last4digits <= 8999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 58 && Fødselsår <= 99 && Last4digits >= 8000 && Last4digits <= 8999)
            {
                Fødselsår += 1800;
            }

            else if (Fødselsår >= 0 && Fødselsår <= 36 && Last4digits >= 9000 && Last4digits <= 9999)
            {
                Fødselsår += 2000;
            }

            else if (Fødselsår >= 37 && Fødselsår <= 99 && Last4digits >= 9000 && Last4digits <= 9999)
            {
                Fødselsår += 1900;
            }

            return Fødselsår;
        }
    }
}
