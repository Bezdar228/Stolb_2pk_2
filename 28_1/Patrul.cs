using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_1
{
    internal class Patrul
    {
        public int chislo;
        public Patrul(int speed)
        {
            chislo = speed;
        }
        public void show(int chislo)
        {
            while (chislo != 200)
            {
                chislo++;
                Console.WriteLine($"Скорость равна {chislo}");
                if (chislo > 80 & chislo < 120)
                {
                    Console.WriteLine("Снизьте немедленно скорость");
                }
                else if (chislo > 120)
                {
                    Console.WriteLine("Снизьте скорость или по вам будет открыт огонь");
                }
            }
        }

    }
}
