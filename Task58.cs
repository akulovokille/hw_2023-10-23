 void InputMatrix(ref int[,] m2)
 {
     for (int i = 0; i < m2.GetLength(0); i++)
     {
         for (int j = 0; j < m2.GetLength(1); j++)
         {
             m2[i, j] = new Random().Next(0, 1000);

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
int n=2;

int[,] a = new int[m, n];
int[,] b = new int[n, m];
int[,] c = new int[m, m];

InputMatrix(ref a);
InputMatrix(ref b);

// code is taken from here :
// https://learn.microsoft.com/ru-ru/cpp/parallel/amp/walkthrough-matrix-multiplication?view=msvc-170

for (int row = 0; row < m; row++) {
        for (int col = 0; col < m; col++) {
            // Multiply the row of A by the column of B to get the row, column of product.
            for (int inner = 0; inner < n; inner++) {
                c[row,col] += a[row,inner] * b[inner,col];
            }
        }
    }

MatrixOutput(a);
Console.WriteLine();
MatrixOutput(b);
Console.WriteLine();
MatrixOutput(c);
