namespace _10._5FinalProject
{
    internal class Program
    {
        static ILogger? Logger { get; set; }
        
        static void Main(string[] args)
        {
            Logger = new Logger();
            Calculate calculate = new Calculate(Logger);
            double value1, value2;

            try
            {
                Console.Write("Value1 = ");
                value1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Value2 = ");
                value2 = Convert.ToDouble(Console.ReadLine());

                double result = ((ICalculate)calculate).Sum(value1, value2);
                Console.Write(result);
            }
            catch (Exception ex)
            {
                Logger.Error("Exception : ");
                Console.Write(ex.Message);
            }
        }
    }
}