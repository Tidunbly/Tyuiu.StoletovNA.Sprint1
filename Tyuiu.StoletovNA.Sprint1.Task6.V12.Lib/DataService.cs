using System.Net.WebSockets;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.StoletovNA.Sprint1.Task6.V12.Lib {
    public class DataService : ISprint1Task6V12 {
        public bool CheckLastWordRepetiton(string value)
        {
           
            string[] strWords = value.Split(' ');
            string strLastWord = strWords[strWords.Length - 1];

            

            int cnt = Regex.Matches(value, strLastWord).Count;

            if (cnt > 1)
            {
                return true;
            }
            else
            {
                return false;
            }            
            

        }
    }
}
