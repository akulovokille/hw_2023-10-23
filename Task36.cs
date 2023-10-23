int[] nArray = new int[10];
for (int i=0; i< nArray.Length; i++)
        nArray [i] = new Random().Next(100, 1000);

Int32 tmpSum = 0;
for (int i=1; i< nArray.Length; i+=2)
    tmpSum += nArray [i];

Console.WriteLine($"[{string.Join(", ", nArray)}]");
Console.WriteLine("Sum of odd elements = " + tmpSum.ToString());

