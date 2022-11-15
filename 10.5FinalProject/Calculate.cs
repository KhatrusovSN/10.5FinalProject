using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._5FinalProject
{
    internal class Calculate : ICalculate
    {
        ILogger Logger { get; }
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }

        double ICalculate.Sum(double x, double y)
        {
            Logger.Event("Sum : ");
            return x + y;
        }
    }
}
