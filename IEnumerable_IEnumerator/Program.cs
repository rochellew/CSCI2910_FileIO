using IEnumerable_IEnumerator;

Person[] peopleArray = new Person[3]
{
    new Person("John", "Doe"),
    new Person("Jim", "Johnson"),
    new Person("Sue", "Smith")
};

People peopleList = new People(peopleArray);
foreach(Person p in peopleList)
{
    Console.WriteLine(p.firstName + " " + p.lastName);
}