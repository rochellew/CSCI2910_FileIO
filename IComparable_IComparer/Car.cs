using System.Collections;

namespace IComparable_IComparer
{
    public class Car : IComparable
    {
        // nested classes

        #region NestedClasses
        // sort ascending by year (on Year property)
        private class SortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.Year > c2.Year)
                    return 1;
                if (c1.Year < c2.Year)
                    return -1;
                else
                    return 0;
            }
        }

        // sort descending on Year property
        private class SortYearDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Car c1 = (Car)a;
                Car c2 = (Car)b;

                if (c1.Year < c2.Year)
                    return 1;
                if (c1.Year > c2.Year)
                    return -1;
                else
                    return 0;
            }
        }

        // descending sort on Make property
        private class SortMakeDescendingHelper : IComparer
        {
            int IComparer.Compare(object? a, object? b)
            {
                Car? car1 = a as Car;
                Car? car2 = b as Car;
                return String.Compare(car2.Make, car1.Make);
            }
        }
        #endregion

        public string Make { get; set; }
        public int Year { get; set; }

        public Car(string make, int year)
        {
            Make = make;
            Year = year;
        }   

        // Implements CompareTo method of IComparable interface
        int IComparable.CompareTo(object? obj)
        {
            Car c = (Car)obj;
            return String.Compare(this.Make, c.Make);

        }

        // Methods that will return IComparer objects for sort helpers
        public static IComparer SortYearAcending()
        {
            return (IComparer) new SortYearAscendingHelper();
        }

        public static IComparer SortYearDescending()
        {
            return new SortYearDescendingHelper() as IComparer;
        }

        public static IComparer SortMakeDescending()
        {
            return new SortMakeDescendingHelper();
        }
    }


}
