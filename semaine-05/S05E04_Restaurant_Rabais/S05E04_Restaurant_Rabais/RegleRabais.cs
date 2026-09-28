using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Rabais
{
    public class RegleRabais
    {
        public static decimal LimiterTotalAZero(decimal total)
        {
            if (total < 0)
            {
                return 0;
            }

            return total;
        }
    }
}
