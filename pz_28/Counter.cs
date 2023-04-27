using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Counter
    {
        public event Action<int> NumberGenerated; // событие генерации числа

        public void GenerateNumbers()
        {
            for (int i = 1; i <= 1000; i++)
            {
                NumberGenerated?.Invoke(i); // вызов события генерации числа
            }
        }
    }
}
    
