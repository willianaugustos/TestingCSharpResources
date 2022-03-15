Console.WriteLine("Here we are creating structs and checking its values...");
var sa = new cityStruct("London");
var sb = sa;
sb.name = "Ankara";

Console.WriteLine($"City from object a: {sa.name}");//output: London
Console.WriteLine($"City from object b: {sb.name}");//output: Ankara


Console.WriteLine("Here we are creating classes and checking its values...");
var ca = new cityClass("London");
var cb = ca;
cb.name = "Ankara";

Console.WriteLine($"City from object a: {ca.name}");//output: Ankara
Console.WriteLine($"City from object b: {cb.name}");//output: Ankara

Console.WriteLine("------------------------------------------------------------------");

