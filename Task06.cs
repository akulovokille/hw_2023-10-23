String tmpStr = "";
const String errMessage = "You've entered not digital value";

Int32 n0 = 0;
Console.WriteLine("Enter any digital value:");
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

if (n0 % 2 == 0)
{
    Console.WriteLine("This is even number");
}
else
{
    Console.WriteLine("This is odd number");
}
