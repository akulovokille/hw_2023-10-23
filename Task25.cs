String tmpStr = "";
const String errMessage = "You've entered not digital value";

int a = 0;
int b = 0;
Console.WriteLine("Enter A:");
tmpStr = Console.ReadLine();
try
{
  a = Convert.ToInt32(tmpStr);
}
catch (System.Exception)
{
    Console.WriteLine(errMessage);
    Environment.Exit(0);
}

Console.WriteLine("Enter B:");
tmpStr = Console.ReadLine();
try
{
  b = Convert.ToInt32(tmpStr);
}
catch (System.Exception)
{
    Console.WriteLine(errMessage);
    Environment.Exit(0);
}


//var1
    Console.WriteLine(Math.Pow(a,b).ToString()  );

//var2
    Console.WriteLine(Power2(a,b).ToString()  );



Int32 Power2(int paramA, int paramB) {
    Int32 result = paramA;

    for(int i=0; i<paramB-1; i++) result*= paramA;

 return result;

}
