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
            List<char> code = new List<char>();
            char codeNum = '0';
            char currentNum = '5';
            foreach (string line in codeLines)
            {
                codeNum = calculateNumber(line, currentNum);
                code.Add(codeNum);
                currentNum = codeNum;
            }
            foreach (char num in code)
            {
                Console.Write(num);
            }
        }

        private static char calculateNumber(string line, char currentNum)
        {
            for (int i = 0; i < line.Length; i++)
            {
                switch (currentNum)
                {
                    case '1':
                        if (line[i] == 'U' || line[i] == 'L' || line[i] == 'R')
                        {
                            currentNum = '1';
                        }
                        else
                        {
                            currentNum = '3';
                        }
                        break;
                    case '2':
                        if (line[i] == 'U' || line[i] == 'L')
                        {
                            currentNum = '2';
                        }
                        else if (line[i] == 'R')
                        {
                            currentNum = '3';
                        }
                        else
                        {
                            currentNum = '6';
                        }
                        break;
                    case '3':
                        if (line[i] == 'U')
                        {
                            currentNum = '1';
                        }
                        else if (line[i] == 'R')
                        {
                            currentNum = '4';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = '2';
                        }
                        else
                        {
                            currentNum = '7';
                        }
                        break;
                    case '4':
                        if (line[i] == 'R' || line[i] == 'U')
                        {
                            currentNum = '4';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = '3';
                        }
                        else
                        {
                            currentNum = '8';
                        }
                        break;
                    case '5':
                        if (line[i] == 'U' || line[i] == 'L' || line[i] == 'D')
                        {
                            currentNum = '5';
                        }
                        else if(line[i] == 'R')
                        {
                            currentNum = '6';
                        }
                        break;
                    case '6':
                        if (line[i] == 'R')
                        {
                            currentNum = '7';
                        }
                        else if (line[i] == 'U')
                        {
                            currentNum = '2';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = '5';
                        }
                        else
                        {
                            currentNum = 'A';
                        }
                        break;
                    case '7':
                        if (line[i] == 'L')
                        {
                            currentNum = '6';
                        }
                        else if (line[i] == 'U')
                        {
                            currentNum = '3';
                        }
                        else if (line[i] == 'D')
                        {
                            currentNum = 'B';
                        }
                        else
                        {
                            currentNum = '8';
                        }
                        break;
                    case '8':
                        if (line[i] == 'D')
                        {
                            currentNum = 'C';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = '7';
                        }
                        else if (line[i] == 'R')
                        {
                            currentNum = '9';
                        }
                        else
                        {
                            currentNum = '4';
                        }
                        break;
                    case '9':
                        if (line[i] == 'D' || line[i] == 'R' || line[i] == 'U')
                        {
                            currentNum = '9';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = '8';
                        }
                        break;
                    case 'A':
                        if (line[i] == 'L' || line[i] == 'D')
                        {
                            currentNum = 'A';
                        }
                        else if (line[i] == 'U')
                        {
                            currentNum = '6';
                        }
                        else
                        {
                            currentNum = 'B';
                        }
                        break;
                    case 'B':
                        if (line[i] == 'D')
                        {
                            currentNum = 'D';
                        }
                        else if (line[i] == 'L')
                        {
                            currentNum = 'A';
                        }
                        else if (line[i] == 'R')
                        {
                            currentNum = 'C';
                        }
                        else
                        {
                            currentNum = '7';
                        }
                        break;
                    case 'C':
                        if (line[i] == 'R' || line[i] == 'D')
                        {
                            currentNum = 'C';
                        }
                        else if (line[i] == 'U')
                        {
                            currentNum = '8';
                        }
                        else
                        {
                            currentNum = 'B';
                        }
                        break;
                    case 'D':
                        if (line[i] == 'D' || line[i] == 'R' || line[i] == 'L')
                        {
                            currentNum = 'D';
                        }
                        else if (line[i] == 'U')
                        {
                            currentNum = 'B';
                        }
                        break;
                }
            }
            return currentNum;
        }
    }
}
