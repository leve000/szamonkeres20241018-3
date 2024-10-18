using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamonkeres3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] homersekletek = new double[7];
            for (int i = 0; i < 7; i++)
            {
                Console.Write("Kérem adja meg a(z) {0}. nap hőmérsékletét: ", i + 1);
                homersekletek[i] = Convert.ToDouble(Console.ReadLine());
            }

            double atlagHomerseklet = homersekletek.Average();
            Console.WriteLine("A hét átlaghőmérséklete: {0} °C", atlagHomerseklet);

            double legmelegebb = homersekletek.Max();
            Console.WriteLine("A legmelegebb nap hőmérséklete: {0} °C", legmelegebb);

            double leghidegebb = homersekletek.Min();
            Console.WriteLine("A leghidegebb nap hőmérséklete: {0} °C", leghidegebb);

            if (homersekletek.Any(h => h < 0))
            {
                Console.WriteLine("Fagypont alatti nap is volt!");
            }
        }
    }
}
