using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle
{
    class Program
    {
        //дано три сторони, потрібно дізнатиссь чи ті сторони можуть бути рикутником, 
        //якщо можуть то обчитити площу трикутника
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter A side");
            string A = Console.ReadLine();
            int somesidea = Convert.ToInt32(A);

            Console.WriteLine("Please enter B side");
            string B = Console.ReadLine();
            int somesideb = Convert.ToInt32(B);

            Console.WriteLine("Please enter C side");
            string C = Console.ReadLine();
            int somesidec = Convert.ToInt32(C);

            int p = somesidea + somesideb + somesidec;

            if (somesidec == somesideb + somesidea)
            {
                Console.WriteLine("Периметр трикутника=" + p);
            }
            else if (somesidea == somesideb + somesidec)
            {
                Console.WriteLine("Периметр трикутника=" + p);
            }
            else if (somesideb == somesidea + somesidec)
            {
                Console.WriteLine("Периметр трикутника=" + p);
            }
            else
            {
                Console.WriteLine("These sides cannot be triangle");
            }
            Console.ReadLine();

        }
        public class Sides
        {
            public int SomeSideA { get; set; }
            public int SomeSideB { get; set; }
            public int SomeSideC { get; set; }

            public Sides(int somesidea, int somesideb, int somesidec)
            {
                SomeSideA = somesidea;
                SomeSideB = somesideb;
                SomeSideC = somesidec;
            }

        }

    }
}
