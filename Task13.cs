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

String tmp2 = n0.ToString();
if (tmp2.Length  < 3 ) {
    Console.WriteLine("There is no 3rd digit in this number");
    Environment.Exit(0);
}

Console.WriteLine(tmp2.Substring (2,1));
