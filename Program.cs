using System;
using System.Text;

namespace test // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main()
        {
            string[] calories = System.IO.File.ReadAllLines(@"C:\programming\csharp\test\test\elfs.txt");
            int maxCalories = 0;
            int pom = 0;
            foreach (string calory in calories)
            {
                if(string.IsNullOrEmpty(calory))
                {
                    if(maxCalories < pom)
                    {
                        maxCalories = pom;
                    }
                    pom = 0;
                }
                else
                {
                    pom += int.Parse(calory);
                }
            }
            if(maxCalories < pom)
            {
                maxCalories = pom;
            }
            Console.WriteLine(maxCalories);
        }
    }
}
