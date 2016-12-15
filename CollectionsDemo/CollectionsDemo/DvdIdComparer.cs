using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class DvdIdComparer : IComparer<DVD>
    {
        public int Compare(DVD dvd1, DVD dvd2)
        {
          if (dvd1.id < dvd2.id)
          {
              return -1;
          }

          else if (dvd1.id > dvd2.id)
          {
              return 1;
          }

          else
          {
              return 0;
          }

        }
    }

    public class DVDPriceComparer : IComparer<DVD>
    {
        public int Compare (DVD dvd1, DVD dvd2)
        {
            if (dvd1.price < dvd2.price)
            {
                return -1;
            }

            if (dvd1.price > dvd2.price)
            {
                return 1;
            }

            else
            {
                return 0;
            }
        }
    }
}
