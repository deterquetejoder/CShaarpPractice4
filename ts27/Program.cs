 //Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

 Console.WriteLine("Enter your number to get the sum of digits in it");
 int num = Convert.ToInt32(Console.ReadLine());

if(num<0)num*=-1;
string number = num.ToString();
int sum = 0;
for (int i = 0; i < number.Length; i++) {
    sum += number[i] - '0';
}
Console.WriteLine($"The sum is {sum}");