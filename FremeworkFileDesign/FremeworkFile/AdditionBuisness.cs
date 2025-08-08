using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FremeworkFile
{
    internal class AdditionBuisness
    {
        int a, b;
        public void SetFirstNumebr(int firstnumber)
        {
            a= firstnumber; 
        }
        public void SetSecondNumebr(int secondnumber)
        {
            b = secondnumber;
        }
        public int Additon()
        {
            return a + b;
        }
    }
}
