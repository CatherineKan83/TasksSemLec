void PrintArray(int[,] arr)
{
    Console.Write("[");
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}");
            if(j<arr.GetLength(1)-1)
            {
                Console.Write(",");
            }
        }
    Console.WriteLine("]");
    }
}
void FillArray(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0);i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j] = new Random().Next(-9,9);
        }
    Console.WriteLine();
    }
}
void FindSum(int[,] arr)
{
    int Pos = 0;
    int Neg = 0;
    for(int i=0; i<arr.GetLength(0);i++)
    {
        for(int j =0; j<arr.GetLength(1); j++)
        {
            if(arr[i,j]>0)
            {
                Pos = Pos + arr[i,j];            
            }
            else Neg = Neg + arr[i,j];
        }
    }
    Console.WriteLine($"Сумма положительных чисел равна -> {Pos}.");
    Console.WriteLine($"Сумма отрицательных чисел равна -> {Neg}.");
}

int[,]array=new int[1,12];
FillArray(array);
PrintArray(array);
FindSum(array);