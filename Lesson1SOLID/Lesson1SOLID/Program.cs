using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1SOLID
{
    class Employee
    {
        public void AddEmployee(int existing, int addNew)
        {
            int result = existing + addNew;

            if(result < 10000)
            {
                Console.WriteLine(result);
            }
            else
            {
                File.AppendAllText("C:\\Error.txt", result.ToString());
            } 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Violation of 'S' in SOLID - Single responsibility principle => meaning that
            // a class should serve only one purpose - it should do only ONE thing

        }
    }
}
