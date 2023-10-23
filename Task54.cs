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


int xTemp = 0;

for (int i = 0; i < matrix.GetLength(0); i++) {

         //xTemp = matrix[i, 0];   

         for (int j = 0; j < matrix.GetLength(1); j++) {


                for (int k = 0; k < matrix.GetLength(1)-1; k++) { 

                if (matrix[i, k] > matrix[i, k+1]) {
                    xTemp = matrix[i, k];
                    matrix[i, k] = matrix[i, k+1];
                    matrix[i, k+1] = xTemp;
                }

                }

         }
}

Console.WriteLine("Sorted matrix :");
MatrixOutput(matrix);
