using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StoletovNA.Sprint1.Task7.V11.Lib {
    public class DataService : ISprint1Task7V11 {
        public double Calculate(double x, double y)
        {
            double n1 = Math.Pow(Math.Log(Math.Sin(x)), x);
            double n2 = Math.Log(1 + Math.Pow(x, 2));
            double n3 = (y - Math.Sqrt(Math.Abs(x)));

            double res = Math.Round((n1 / n2 + n3), 3);
            return res;
        }
    }
}
