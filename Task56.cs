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


int m=10;
int n=15;

int[,] matrix = new int[m, n];
InputMatrix(ref matrix);
MatrixOutput(matrix);

int rowIndexWithMinSun = 0;
int keepSum = 0;

int tempSum = 0;

for (int j = 0; j < matrix.GetLength(1); j++) {
   tempSum += matrix[0,j];
}
keepSum = tempSum;
rowIndexWithMinSun = 0;

for (int i = 1; i < matrix.GetLength(0); i++) {

    tempSum = 0;
         for (int j = 0; j < matrix.GetLength(1); j++) {
            tempSum += matrix[i,j];
         }

    if(tempSum < keepSum) {
        keepSum = tempSum;
        rowIndexWithMinSun = i;
    }    
}

Console.Write($"Row index with minimum sum is {rowIndexWithMinSun}");

