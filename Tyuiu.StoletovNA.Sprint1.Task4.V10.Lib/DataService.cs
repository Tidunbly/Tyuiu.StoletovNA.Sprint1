using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StoletovNA.Sprint1.Task4.V10.Lib {
    public class DataService : ISprint1Task4V10 {
        public double Calculate(double a)
        {
            double n1 = 1 + Math.Cos(a);
            double n2 = Math.Pow(Math.Sin(a), 2);
            var result = Math.Round(n1 / n2, 3);
            return result;
        }
    }
}
