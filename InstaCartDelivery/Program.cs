using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaCartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery delivery = new Delivery([200, 20, 15], [[300, 40, 5], [600, 40, 10]);
            Console.WriteLine(delivery);
        }
    }
}
