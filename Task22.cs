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

if (n0 < 1 || n0 > 10000) {
    Console.WriteLine("Wrong range");
    Environment.Exit(0);
}

for(int i=1; i <= n0; i++) {

    Console.Write(Math.Pow(i,2).ToString() + " ");

}
