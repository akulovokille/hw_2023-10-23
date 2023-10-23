int[] nArray = new int[10];
for (int i=0; i< nArray.Length; i++)
        nArray [i] = new Random().Next(100, 1000);

int numberOfEven = 0;
for (int i=0; i< nArray.Length; i++)
    if(nArray[i] % 2 == 0 ) numberOfEven += 1;

Console.WriteLine($"[{string.Join(", ", nArray)}]");
Console.WriteLine("Number of evens = " + numberOfEven.ToString());

