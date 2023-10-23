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

if (n0 < 100 || n0 > 999) {
    Console.WriteLine("Wrong range");
    Environment.Exit(0);
}

int n1 = n0 / 100;
int n3 = n0 % 10;
Console.WriteLine(n1 * 10 + n3);
