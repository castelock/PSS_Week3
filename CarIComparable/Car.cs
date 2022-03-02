using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarIComparable
{
    public class Car : IComparable
    {
        // Beginning of nested classes.
        // Nested class to do ascending sort on year property.
        private class SortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year > c2.year)
                    return 1;

                if (c1.year < c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on year property.
        private class SortYearDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.year < c2.year)
                    return 1;

                if (c1.year > c2.year)
                    return -1;

                else
                    return 0;
            }
        }

        // Nested class to do descending sort on make property.
        private class SortMakeDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;
                return String.Compare(c2.make, c1.make);
            }
        }
        // End of nested classes.

        private int year;
        private string make;

        public Car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        // Implement IComparable CompareTo to provide default sort order.
        public int CompareTo(object? obj)
        {
            Car c = (Car)obj;
            return String.Compare(this.make, c.make);
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortYearAscending()
        {
            return (IComparer)new SortYearAscendingHelper();
        }
        // Method to return IComparer object for sort helper.
        public static IComparer SortYearDescending()
        {
            return (IComparer)new SortYearDescendingHelper();
        }
        // Method to return IComparer object for sort helper.
        public static IComparer SortMakeDescending()
        {
            return (IComparer)new SortMakeDescendingHelper();
        }
    }
}
