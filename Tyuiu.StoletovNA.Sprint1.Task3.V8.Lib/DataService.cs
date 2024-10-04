using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.StoletovNA.Sprint1.Task3.V8.Lib {
    public class DataService : ISprint1Task3V8 {
        public double IncomeAmount(double startAmount, double percent, double timeDays)
        {
            double timeYears = timeDays / 365.0;
            double totalAmount = startAmount * (1 + percent/100 * timeYears);
            double income = totalAmount - startAmount;
            double incomeRounded = Math.Round(income, 3);
            return incomeRounded;
        }
    }
}
