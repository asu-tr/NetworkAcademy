using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W02_02_Methods_Part2
{
    internal class Tax
    {
        public decimal Calculate(decimal price, int category)
        {
            switch (category)
            {
                case 1:
                    return KDV05(price);

                case 2:
                    return KDV08(price);

                case 3:
                    return KDV18(price);

                default:
                    return 0;
            }
        }

        public decimal KDV05(decimal price)
        {
            decimal kdvv = price * 05 / 100;
            return kdvv;
        }

        public decimal KDV08(decimal price)
        {
            decimal kdvv = price * 08 / 100;
            return kdvv;
        }

        public decimal KDV18(decimal price)
        {
            decimal kdvv = price * 18 / 100;
            return kdvv;
        }
    }
}