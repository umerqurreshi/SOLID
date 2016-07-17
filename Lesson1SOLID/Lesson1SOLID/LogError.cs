using Lesson1SOLID.Interfaces;
using System.Diagnostics;

namespace Lesson1SOLID
{
    public class LogError : ILogError
    {
        public void Log(int error)
        {
            Trace.TraceError($"{error} is greater than 10,000 please try again!");
        }
    }
}
