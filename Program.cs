/*Using nonymous Type
Ref.: Beginning C# 7 Programming with Visual Studio by Benjamin Perkins et al., Wrox, 2018
I modified the problem code for .Net 6
*/
// See https://aka.ms/new-console-template for more information


var animals = new[]
    {
        new {Name = "Benjamin", Age = 42, Weight = 185},
        new {Name = "Benjamin", Age = 42, Weight = 185},
        new {Name = "Andrea", Age = 46, Weight = 109}       
    };

    Console.WriteLine(animals[0].ToString());
    Console.WriteLine(animals[0].GetHashCode());
    Console.WriteLine(animals[1].GetHashCode());
    Console.WriteLine(animals[2].GetHashCode());
    Console.WriteLine(animals[0].Equals(animals[1]));
    Console.WriteLine(animals[0].Equals(animals[2]));
    Console.WriteLine(animals[0] == animals[1]);
    Console.WriteLine(animals[0] == animals[1]);
    Console.ReadKey();