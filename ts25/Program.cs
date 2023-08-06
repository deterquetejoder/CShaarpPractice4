Console.Write("enter A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("enter B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;


if (b<1)
Console.Write("number b must be natural");
else
{
for(;b!=0;b=b-1)
{
c = c * a;
}
Console.Write($"Number A  B times equals {c}");
}