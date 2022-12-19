// задача в уроке
/*
 static extern int SumOfNums (int num);
{
    int num=1;
    int sum=1;
    while(num > 1)
    {
        sum+=num;
        num --;
    }
    return sum;
}
Console.Write("Input an integer numder N: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = SumOfNums(number);
Console.WriteLine($"Sum of numbers from 1 to N is {result}");
*/
// Дз 
// задача 1 напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

/*
Console.Write("Input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int naturalDigree(int number);

int i = 1;
int result = 1;

while(i <= numberB)
{
    result = result * numberA;
}
i++;
int naturalDigree = naturalDigree(int number);

Console.WriteLine("result:{naturalDigree}");
*/

/*

Console.Write("Input a number A: ");
int a = Convert.ToInt32(Console.ReadLine());  
Console.Write("Input a number B: ");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("result: " + step);
*/

 /* 
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

*/

// zadacha 2
/*
Console.Write("Input a number: ");
int numberN = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int numberN)
  
  {
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      advance = numberN - numberN % 10;
      result = result + (numberN - advance);
      numberN = numberN / 10;
    }
   return result;
  }

int sumNumber = SumNumber(numberN);
Console.WriteLine("result: " + sumNumber);
*/

// zadacha 3 Напишите программу, которая
// задаёт массив из 8 элементов и выводит их на экран.

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());  
  
int[] array = new int[] {number};

var str = string.Join(" ",array);
Console.WriteLine(str);      
*/
