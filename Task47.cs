
 void InputMatrix(ref double[,] m2)
 {
     for (int i = 0; i < m2.GetLength(0); i++)
     {
         for (int j = 0; j < m2.GetLength(1); j++)
         {
             m2[i, j] = GetPseudoDoubleWithinRange(-100,100);

         Console.WriteLine();
         }
     }
 }


 void MatrixOutput(double[,] m3)
 {
     for (int i = 0; i < m3.GetLength(0); i++)
     {
         for (int j = 0; j < m3.GetLength(1); j++)
         {
             Console.Write($"{m3[i,j]} \t");
         }
         Console.WriteLine();
     }
 }

static double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
{
    var random = new Random();
    var rDouble = random.NextDouble();
    var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
    return rRangeDouble;
}


int m=3;
int n=4;

double[,] matrix = new double[m, n];
InputMatrix(ref matrix);
MatrixOutput(matrix);

