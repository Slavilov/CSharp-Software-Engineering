using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        public DateModifier(string start, string end)
        {
            this.startDate = start;
            this.endDate = end;
        }

        private string startDate;
        private string endDate;

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public int DifferenceBetweenTwoDates(string startDate, string endDate)
        {
            int difference = 0;
            string newStartDate = startDate.Replace(' ', '/');
            string newEndDate = endDate.Replace(' ', '/');
            DateTime start = DateTime.Parse(newStartDate);
            DateTime end = DateTime.Parse(newEndDate);

            return difference = (int)(end - start).TotalDays;
        }

    }
}
