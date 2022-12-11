using System;
using System.Text;
using System.Threading.Tasks.Sources;

namespace test 
{
    internal class Program
    {
        static void Main()
        {
            string[] strategies = System.IO.File.ReadAllLines(@"C:\programming\csharp\test\test\elfs.txt");
            int score = 0;
            foreach (string strategy in strategies)
            {
                string[] splits = strategy.Split();
                if (splits[0] == "A")//rock
                {
                    if(splits[1] == "X")
                    {
                        score += 3+1;
                    }
                    else if(splits[1] == "Y")
                    {
                        score += 6+2;
                    }
                    else
                    {
                        score += 3;
                    }
                }
                else if (splits[0] == "B")//paper
                {
                    if (splits[1] == "X")
                    {
                        score += 1;
                    }
                    else if (splits[1] == "Y")
                    {
                        score += 3 + 2;
                    }
                    else
                    {
                        score += 6 + 3;
                    }
                }
                else //scissors
                {
                    if (splits[1] == "X")
                    {
                        score += 6 + 1;
                    }
                    else if (splits[1] == "Y")
                    {
                        score += 2;
                    }
                    else
                    {
                        score += 3 + 3;
                    }
                }

            }

            Console.WriteLine(score);
            
        }
    }
}
