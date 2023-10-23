int[] nArray = new int[10];
for (int i=0; i< nArray.Length; i++)
        nArray [i] = new Random().Next(100, 1000);

Int32 xMin = nArray[0], xMax = nArray[0];

for (int i=1; i< nArray.Length; i++) {
    if(nArray [i] < xMin) xMin = nArray [i];
    if(nArray [i] > xMax) xMax = nArray [i];
}

Console.WriteLine($"[{string.Join(", ", nArray)}]");
Console.WriteLine("Difference is " + (xMax-xMin).ToString());

