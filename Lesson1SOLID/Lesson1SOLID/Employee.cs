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
    // the error ... Let us now create a class called Student class - but student class
    // will not violate S in SOLID....

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

    // 2. Consider Student class
    // Does not violate S in SOLID - now logging is done by LogError class - remember
    // abstractions should not depend on details - details should depend upon abstractions
    // We abstracted out the logging here to LogError.cs. Later you will see how having 
    // concrete implementations of a class within a class can make unit testing difficult. 
    // Key word from lesson 1: ABSTRACTIONS - class should have one responsibility - everything
    // else should be ABSTRACTED out.
    class Student
    {
        private readonly ILogError _logError;

        public Student(ILogError logError)
        {
            _logError = logError;
        }

        public void AddStudent(int existing, int addNew)
        {
            int result = existing + addNew;

            if (result < 10000)
            {
                Console.WriteLine(result);
            }
            else
            {
                _logError.Log(result);
            }
        }
    }
}
