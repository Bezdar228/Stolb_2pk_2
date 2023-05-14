using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MyDelegate(int speed);

namespace _28_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            Patrul A = new Patrul(100);
            Patrul B = new Patrul(130);

            machine.IncrSpeed += A.show;
            machine.Counter(1);
            Console.ReadKey();
        }
    }
}