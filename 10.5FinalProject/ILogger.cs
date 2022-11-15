using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5FinalProject
{
    internal interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
}
