using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Wait
    {
        private  int _valueToWaitFor;

        public Wait(int valueToWaitFor)
        {
            _valueToWaitFor = valueToWaitFor;
        }

        public void WaitForValue(Counter counter)
        {
            counter.NumberGenerated += OnNumberGenerated; 
        }

        private void OnNumberGenerated(int number)
        {
            if (number == _valueToWaitFor)
            {
                Console.WriteLine($"Значение {number} появилось!");
            }
        }
    }
}
