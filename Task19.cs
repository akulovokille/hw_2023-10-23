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
if (tmp2.Length  != 5 ) {
    Console.WriteLine("There is no 5-digit number");
    Environment.Exit(0);
}

if (tmp2.Substring (0,1) == tmp2.Substring (4,1) && tmp2.Substring (1,1) == tmp2.Substring (3,1) ) Console.WriteLine("Yes"); else Console.WriteLine("No");

