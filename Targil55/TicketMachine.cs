using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Targil55
{
    public class TicketMachine
    {
        private int Price;
        public int GetPrice()
        {
            this.Price = 50;
            return Price;
        }
        public int GetTotal(int num)
        {
            if (num < 1)
                return 0;// Console.WriteLine("Please choose quantity more than 0 !");
            return num * GetPrice();
        }
    }
}
