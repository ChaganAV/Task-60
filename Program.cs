// Создадим массив через random
Random rnd = new Random();
int minR = 2; int maxR = 5;
int rows = rnd.Next(minR,maxR); int columns = rows; // строки и колонки массива 
//int columns = rnd.Next(minR, maxR);
int rowC = 0;
int[,] matrixA = new int[rows,columns]; // массив A
int[,] matrixB = new int[columns,rows]; // массив B

int[,] matrixC = new int[rows,columns];
int minRnd = 1; int maxRnd = 10; // для random

//
FillRandomArray(matrixA);
Print2DArray(matrixA);

Console.WriteLine();
FillRandomArray(matrixB);
Print2DArray(matrixB);

PowerMatrix(matrixA,matrixB,matrixC);
//PowerMatrix(test1,test2,test3);
Console.WriteLine();

Print2DArray(matrixC);
//Print2DArray(test3);


// Функции 

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minRnd,maxRnd);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}