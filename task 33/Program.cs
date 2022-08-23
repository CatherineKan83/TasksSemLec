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
                arr[i,j]= new Random().Next(1,400);
            }
            else arr[i,j]= - new Random().Next(1,400);            
        }
    Console.WriteLine();
    }
}
void Check(int[,]arr)
{
    Console.WriteLine("Введите число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int x = 0;
    Console.WriteLine("Проверяем, есть ли заданное число в масиве...");
    
    for(int i = 0; i<arr.GetLength(0); i++)
    {
        for(int j = 0; j<arr.GetLength(1); j++)
        {          
            if(b == arr[i,j])
            {
                Console.WriteLine($"Число {b} присутствует. ");
                x ++;
                break;
            }           
        }
                                        
    
    }
    if(x==0)
    {
            Console.WriteLine($"Число {b} отсутствует. ");  
    }
    
}
Console.Write("Укажите размер массива: ");
int c = Convert.ToInt32(Console.ReadLine());
int[,]array = new int[1, c];
FillArray(array);
PrintArray(array);
Check(array);