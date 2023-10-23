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


 void MatrixOutput(int[,] m3)
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



int m=3;
int n=4;

int[,] matrix = new int[m, n];
InputMatrix(ref matrix);
MatrixOutput(matrix);

double tmpSum = 0;
double tmp2 = 0;

     for (int j = 0; j < matrix.GetLength(1); j++)
     {
         tmpSum  = 0;   
         for (int i = 0; i < matrix.GetLength(0); i++)
         {
             tmpSum += matrix[i,j];
         }
         tmp2 = tmpSum / matrix.GetLength(0);
         Console.WriteLine($"Arithmetical mean of column {j} is " + tmp2.ToString("0.###") );
     }

