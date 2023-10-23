 void InputMatrix(ref int[,] m2)
 {
     for (int i = 0; i < m2.GetLength(0); i++)
     {
         for (int j = 0; j < m2.GetLength(1); j++)
         {
             m2[i, j] = new Random().Next(-10, 1000);

         }
     }
 }


int m=3;
int n=4;

int[,] matrix = new int[m, n];
InputMatrix(ref matrix);

Console.Clear();
Console.WriteLine("Enter indexes of element devided by blank symbol :");
int[]indpos = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray(); // 4 3

if(indpos[0] > matrix.GetLength(0)-1 || indpos[1] > matrix.GetLength(1)-1)
    Console.WriteLine("Wrong range");
else
    Console.WriteLine(matrix[indpos[0],indpos[1]]);

