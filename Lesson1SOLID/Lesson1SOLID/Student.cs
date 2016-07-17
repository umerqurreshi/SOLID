using Lesson1SOLID.Interfaces;
using System;

namespace Lesson1SOLID
{
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
