using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    [Serializable]
    public class Date
    {
        private int day;
        private int month;
        private int year;

        public Date()
        {
            this.Day = 0;
            this.Month = 0;
            this.Year = 0;
        }
        public Date(int day, int month, int year)
        {
            this.Day = day;
            this.Month = month;
            this.Year = year;
        }

        public int Day
        {
            get
            {
                if (this.day >= 1 && this.day <= 31)
                {
                    return this.day;
                }
                else { return 0; }
            }
            set
            {
                this.day = value;
            }
        }

        public int Month
        {
            get
            {
                return (this.month >= 1 && this.month <= 12) ? this.month : 0;
            }
            set => this.month = value;
        }
        public int Year
        {
            get { return this.year; }
            set => this.year = value;
        }
        public override string ToString()
        {
            return $"{this.year}/{this.Month}/{this.Day}";
        }
    }
}
