
int[] anyValue = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int nCount = 0;


foreach(int nItem in anyValue) 
    if(nItem > 0) nCount+= 1;

//Console.WriteLine(anyValue);
Console.WriteLine($"Number of positive values is {nCount}");
