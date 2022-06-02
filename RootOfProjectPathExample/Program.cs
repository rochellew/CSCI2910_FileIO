/////////////////////////////////////////////////////////////////////////////////////////////////////
/// | from here to              here| Here is my project     | The remaining folders 
/// | is my folder setup to my      | folder. This holds my  | is when we compile and the program runs
/// | project                       | folder with my code and| This keeps the executable code separate 
/// |                               | the .sln file          | from your solution
/// \Users\whroc\Documents\CSCI 2910\RootOfProjectPathExample\bin\Debug\net6.0
Console.WriteLine(Directory.GetCurrentDirectory());

// This outputs:
// \Users\whroc\Documents\CSCI 2910\RootOfProjectPathExample\bin\Debug
// Notice the net6.0 folder is removed
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()));

// This outputs:
// \Users\whroc\Documents\CSCI 2910\RootOfProjectPathExample\bin
// Notice the net6.0 and Debug folders are gone
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent);


// This outputs:
// \Users\whroc\Documents\CSCI 2910\RootOfProjectPathExample\
// This is the folder your solution explorer shows
Console.WriteLine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent);

// use ToString() to store the root of the project directory
var rootOfProjectString = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();

// recall @ symbol will escape characters for me like the backslash
var squirtlePath = rootOfProjectString + @"\Images\squirtle.jpg";

Console.WriteLine(squirtlePath);

