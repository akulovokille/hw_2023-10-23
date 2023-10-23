String tmpStr = "";
const String errMessage = "You've entered not digital value";

Int32 n0 = 0;
Int32 n1 = 0;

Console.WriteLine("Enter 1st digit:");
tmpStr = Console.ReadLine();
try
{
  n0 = Convert.ToInt32(tmpStr);
}
catch (System.Exception)
{
    Console.WriteLine(errMessage);
    Environment.Exit(0);
}

Console.WriteLine("Enter 2nd digit:");
tmpStr = Console.ReadLine();
try
{
  n1 = Convert.ToInt32(tmpStr);
}
catch (System.Exception)
{
    Console.WriteLine(errMessage);
    Environment.Exit(0);
}

if (n0 == n1) {
        Console.WriteLine("Entered values are equal");
}
        else
        {
           if(n1 > n0) n0 = n1;
           Console.WriteLine("Max = " + n0.ToString());
        }
