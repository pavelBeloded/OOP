using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal interface IDrivable
    {
        void Start();

        void Stop();
        void Accelerate(int power);

        string GetInfo();
    }
}
