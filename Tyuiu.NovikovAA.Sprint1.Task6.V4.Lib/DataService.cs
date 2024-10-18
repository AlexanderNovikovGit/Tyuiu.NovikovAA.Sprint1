using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.NovikovAA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            String[] worlds = value.Split(' ');
            string answer = string.Empty;
            foreach (String world in worlds)
            {

                if (world.Contains("нн"))
                {
                    answer += " " + world;
                }
            }
            answer = answer.Trim();
            return answer;
        }
    }
}
