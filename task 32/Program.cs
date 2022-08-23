void PrintArray(int[,]arr)
{
    Console.Write("[");
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}");
            if(j<arr.GetLength(1)-1)
            {
                Console.Write(",");
            }
        }
    Console.Write("]");
    }
}
void FillArray(int[,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1); j++)
        {
            if(j<arr.GetLength(1)-2)
            {
                arr[i,j]= new Random().Next(1,10);
            }
            else arr[i,j]= - new Random().Next(1,10);            
        }
    Console.WriteLine();
    }
}
void Switch(int[,]arr)
{
    for(int i=0; i<arr.GetLength(0); i++)
    {
        for(int j=0;j<arr.GetLength(1);j++)
        {
            arr[i,j]=arr[i,j]*-1;                                    
        }
    Console.WriteLine();
    }
}
Console.Write("Введите замер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,]array= new int [1, c];
FillArray(array);
PrintArray(array);
Console.Write(" = ");
Switch(array);
PrintArray(array);