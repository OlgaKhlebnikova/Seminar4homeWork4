Console.Clear();
Console.WriteLine("Какую задачу вы хотите проверить (1/2/3/4)? ");
int Task = Convert.ToInt32(Console.ReadLine());

if(Task == 1){
    Task1();
}
else if(Task == 2){
    Task2();
}
else if(Task == 3){
    Task3();
}

else if(Task == 4){
    Task4();
}

void Task1()
{ 
/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16  */
Console.WriteLine("Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine();
    Console.WriteLine("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Результат возведения {A} в степень {B} равен ");
    Console.WriteLine(Exstent(A,B));
    int Exstent(int A , int B)
    {
        int result = A;
            for (int i =1; i < B; i++)
            {
                result = result*A;            
            }   
        return result;
    }
}


void Task2()
{
/* Напишите программу, которая принимает на вход число  и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

    Console.WriteLine("Напишите программу, которая принимает на вход число  и выдаёт сумму цифр в числе.");
    Console.WriteLine();
    Console.WriteLine("Введите число: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"Сумма цифр в числе {Num} равна {SumInNum(Num)}");
    int SumInNum(int Num)
    {
        string Number = Num.ToString();
        int Sum = int.Parse(Number[0].ToString());
        
        for (int i = 1; i < Number.Length; i++)
            {
                Sum = Sum + int.Parse(Number[i].ToString());
            }
        return Sum;
    }
} 

void Task3()

{
/* Напишите программу, которая задаёт массив из N элементов и выводит их на экран
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */
 
    Console.WriteLine("Напишите программу, которая задаёт массив из N элементов и выводит их на экран. ");
    Console.WriteLine();
    Console.WriteLine("Введите число элементов массива: ");
    int N = Convert.ToInt32(Console.ReadLine());
    int RandomNum = new Random().Next(1,100);
    Console.WriteLine($"В массиве будут случайные числа от -{RandomNum} до +{RandomNum}");
    Console.WriteLine();
    
    int[] Random01(int[] array_random)
    {
    Random rnd = new Random();
    for (int i = 0; i < array_random.Length; i++)
    {
            array_random[i] = rnd.Next(-RandomNum, RandomNum+1);
    }

    return array_random;
    }

    int[] array = new int[N];
    array = Random01(array);
    
    Console.Write("Массив [" + String.Join(",",array) + "]");   
} 

void Task4()

{
/* Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями
в диапазоне от -10 до 10 и найти максимальное значение среди них.
[-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
[-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
[-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] ->  7 */

    Console.WriteLine("Напишите программу, которая задаёт массив из 10 элементов, которые необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них");
    Console.WriteLine();
        
    int[] Random01(int[] array_random)
    {
    Random rnd = new Random();
    for (int i = 0; i < array_random.Length; i++)
    {
            array_random[i] = rnd.Next(-10, 11);
    }

    return array_random;
    }

    int[] array = new int[10];
    array = Random01(array);
    
   // Console.Write("Массив [" + String.Join(",",array) + "]");
    
    int max = array[0];
 
    for (int i = 1; i < array.Length; i++)
        {
            if (max < array[i])
                max = array[i];
        }
    Console.WriteLine();
    Console.WriteLine("Наибольшей цифрой в массиве [" +String.Join(",",array) + "] является " + max);

} 