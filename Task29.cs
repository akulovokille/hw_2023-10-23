int[] nArray = new int[8];
for(int i=0; i< nArray.Length; i++)
    nArray [i] = new Random().Next(0, 100);

Console.WriteLine($"[{string.Join(", ", nArray)}]");
