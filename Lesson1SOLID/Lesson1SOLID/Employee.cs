using Lesson1SOLID.Interfaces;
using System;
using System.Diagnostics;
using System.IO;

namespace Lesson1SOLID
{
    // Violation of 'S' in SOLID - Single responsibility principle => meaning that
    // a class should serve only one purpose - it should do only ONE thing
    // 1. Consider Employee class:
    // Employee class prints results that are less than 10000 in value but it is also recording
    // the error ... 

        // Violates S in SOLID
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
                Trace.TraceError($"{result} is greater than 10,000 please try again!");
            } 
        }
    }
}
