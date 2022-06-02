// IComparable & IComparer
using IComparable_IComparer;


// create an array of Car objects
Car[] arrayOfCars = new Car[6]
{
    new Car("Ford", 1992),
    new Car("Fiat", 1988),
    new Car("Honda", 1932),
    new Car("Chevy", 1999),
    new Car("Mazda", 1967),
    new Car("Dodge", 1981),
};

Console.WriteLine("Array - Unsorted\n");
foreach(Car car in arrayOfCars)
    Console.WriteLine(car.Make + "\t\t" + car.Year);

// Demo IComparable by sorting array with "default" sort order
Console.WriteLine("\nArray - Sorted by Make (Ascending - IComparable)\n");
Array.Sort(arrayOfCars);
foreach (Car car in arrayOfCars)
    Console.WriteLine(car.Make + "\t\t" + car.Year);

// Demo ascending sort of numeric values with IComparer
Console.WriteLine("\nArray - Sorted by Year (Ascending - IComparer)\n");
Array.Sort(arrayOfCars, Car.SortYearAcending());
foreach (Car car in arrayOfCars)
    Console.WriteLine(car.Make + "\t\t" + car.Year);

// Demo descending sort of numeric values with IComparer
Console.WriteLine("\nArray - Sorted by Year (Descending - IComparer)\n");
Array.Sort(arrayOfCars, Car.SortYearDescending());
foreach (Car car in arrayOfCars)
    Console.WriteLine(car.Make + "\t\t" + car.Year);

// Demo descending sort of string values with IComparer
Console.WriteLine("\nArray - Sorted by Make (Descending - IComparer)\n");
Array.Sort(arrayOfCars, Car.SortMakeDescending());
foreach (Car car in arrayOfCars)
    Console.WriteLine(car.Make + "\t\t" + car.Year);



