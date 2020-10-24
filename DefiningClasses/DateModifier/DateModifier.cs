using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public string FirstDate { get; set; }
        public string SecondDate { get; set; }

        public void ReturnDifferenceInDays()
        {
            DateTime firstDate = Convert.ToDateTime(Console.ReadLine());
            DateTime secondDate = Convert.ToDateTime(Console.ReadLine());
            var difference = firstDate - secondDate;

            Console.WriteLine(Math.Abs(difference.Days));
        }
    }
}
