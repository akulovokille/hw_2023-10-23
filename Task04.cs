String tmpStr = "";
const String errMessage = "You've entered not digital value";

Int32 n0 = 0;
const int numberOfComparedValues = 3;
Int32[] arrayForCompare = new Int32[numberOfComparedValues];

Int32 maxValue = 0;

for(int i=0; i < numberOfComparedValues; i++) {

    Console.WriteLine("Enter " + (i+1).ToString() + " digit:");
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
    arrayForCompare[i] = n0;
}

maxValue = arrayForCompare[0];
for(int i=1; i < numberOfComparedValues; i++) {
    if (arrayForCompare[i] > maxValue ) maxValue = arrayForCompare[i];
}

Console.WriteLine("Max value is " + maxValue.ToString());
