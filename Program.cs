using System;
using System.Text;

namespace test // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            string[] calories = System.IO.File.ReadAllLines(@"C:\programming\csharp\test\test\elfs.txt");
            int[] topThree = new int[3] {0,0,0};
            int pom = 0;
            int lowest = 0;
            foreach (string calory in calories)
            {
                if(string.IsNullOrEmpty(calory))
                {
                    lowest = Array.IndexOf(topThree, topThree.Min());
                    if (topThree[lowest] < pom)
                    {
                        topThree[lowest] = pom; 
                    }
                    pom = 0;
                }  
                else
                {
                    pom += int.Parse(calory);
                }
            }

            lowest = Array.IndexOf(topThree, topThree.Min());
            if (topThree[lowest] < pom)
            {
                topThree[lowest] = pom;
            }

            Console.WriteLine(topThree[0] + topThree[1] + topThree[2]);
            //Console.WriteLine(topThree[0]);
           // Console.WriteLine(topThree[1]);
            //Console.WriteLine(topThree[2]);
        }
    }
}
