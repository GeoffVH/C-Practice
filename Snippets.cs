// Neat syntax that I've researched about or come up with. 
// This is all snippet code. The file isn't meant to be run as a whole.


var Arr_Of_Strings = new List<string>(){"Hello!", "World!", "--------", "        "};
foreach(string i in Arr_Of_Strings) Console.WriteLine(i);
Arr_Of_Strings.ForEach(i => Console.WriteLine(i));
Arr_Of_Strings.ForEach(Console.WriteLine);   //Implicit conversion of WriteLines
