Random rnd = new Random();
int minR = 1; int maxR = 10;
int[,,] cube = new int[2,2,2];

FillArray(cube);
Print3DArray(cube);

// Функции 

void FillArray(int[,,] array)
{
    int num = 10;
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            for(int z = 0; z < array.GetLength(2); z++)
            {
                num+=rnd.Next(minR,maxR);
                array[row,col,z] = num;
            }
        }
    }
}

void Print3DArray(int[,,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            for(int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[i,j,z]}({i},{j},{z}) ");
            Console.WriteLine();
        }
        
    }
}