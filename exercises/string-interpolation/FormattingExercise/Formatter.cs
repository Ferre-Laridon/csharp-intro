using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingExercise
{
    internal class Formatter
    {

        internal static string Greet(string name)
        {
            return $"Hello, {name}";
        }

        internal static string FormatDate(int day, int month, int year)
        {
            return $"{day:00}/{month:00}/{year}";
        }
    }
}
