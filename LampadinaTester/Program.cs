using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLampadina;

namespace LampadinaTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Lampadina lp1 = new Lampadina("spenta", 5);
            Console.WriteLine("Quanti click vuoi fare? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(lp1.Click());
            }
        }
    }
}