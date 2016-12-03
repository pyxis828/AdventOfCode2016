using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace BathroomCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("..\\..\\Code.txt");
            List<string> codeLines = new List<string>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        codeLines.Add(line);
                    }
                }
            }
            List<int> code = new List<int>();
            int codeNum = 0;
            int currentNum = 5;
            foreach (string line in codeLines)
            {
                codeNum = calculateNumber(line, currentNum);
                code.Add(codeNum);
                currentNum = codeNum;
            }
            foreach (int num in code)
            {
                Console.Write(num);
            }
        } 

    private static int calculateNumber(string line, int currentNum)
    {
        for (int i=0; i<line.Length; i++)
        {
                var direction = (line[i]);
            switch (currentNum)
            {
                case 1:
                    if (line[i] == 'U' || line[i] == 'L')
                    {
                        currentNum = 1;
                    }
                    else if (line[i] == 'R')
                    {
                        currentNum = 2;
                    }
                    else
                    {
                        currentNum = 4;
                    }
                    break;
                case 2:
                    if (line[i] == 'U')
                    {
                        currentNum = 2;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 1;
                    }
                    else if (line[i] == 'R')
                    {
                        currentNum = 3;
                    }
                    else
                    {
                        currentNum = 5;
                    }
                    break;
                case 3:
                    if (line[i] == 'U' || line[i] == 'R')
                    {
                        currentNum = 3;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 2;
                    }
                    else
                    {
                        currentNum = 6;
                    }
                    break;
                case 4:
                    if (line[i] == 'L')
                    {
                        currentNum = 4;
                    }
                    else if (line[i] == 'U')
                    {
                        currentNum = 1;
                    }
                    else if (line[i] == 'R')
                    {
                        currentNum = 5;
                    }
                    else
                    {
                        currentNum = 7;
                    }
                    break;
                case 5:
                    if (line[i] == 'U')
                    {
                        currentNum = 2;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 4;
                    }
                    else if (line[i] == 'R')
                    {
                        currentNum = 6;
                    }
                    else
                    {
                        currentNum = 8;
                    }
                    break;
                case 6:
                    if (line[i] == 'R')
                    {
                        currentNum = 6;
                    }
                    else if (line[i] == 'U')
                    {
                        currentNum = 3;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 5;
                    }
                    else
                    {
                        currentNum = 9;
                    }
                    break;
                case 7:
                    if (line[i] == 'L' || line[i] == 'D')
                    {
                        currentNum = 7;
                    }
                    else if (line[i] == 'U')
                    {
                        currentNum = 4;
                    }
                    else
                    {
                        currentNum = 8;
                    }
                    break;
                case 8:
                    if (line[i] == 'D')
                    {
                        currentNum = 8;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 7;
                    }
                    else if (line[i] == 'R')
                    {
                        currentNum = 9;
                    }
                    else
                    {
                        currentNum = 5;
                    }
                    break;
                case 9:
                    if (line[i] == 'D' || line[i] == 'R')
                    {
                        currentNum = 9;
                    }
                    else if (line[i] == 'L')
                    {
                        currentNum = 8;
                    }
                    else
                    {
                        currentNum = 6;
                    }
                    break;
                }
             }
          return currentNum;
       }
    }
}
