//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int Input(string msg)
{
    Console.WriteLine(msg);
 int res = Convert.ToInt32(Console.ReadLine());
 return res;
}

int size =8;

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    Random rand = new Random();
    for(int i = 0;i<size;i++)
    {
        array[i]=rand.Next(minValue,maxValue+1);
    } return array;




}
void PrintArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine(array[i]);
    }
}

int minValue = Input("Enter the minimal value of the array's elements");
int maxValue = Input("Enter the maximal value of the array's elements");

PrintArray(FillArray(size,minValue,maxValue));