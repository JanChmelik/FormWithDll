namespace Calculator
{
    /// <summary>
    /// Simple calculator-type based class with async methodes for math operations:
    /// 1)  Addition
    /// </summary>
    public static class Calculations
    {
        public async static Task<double> Addition( double value1, double value2)
        {
            return value1 + value2;
        }
    }
  
}
