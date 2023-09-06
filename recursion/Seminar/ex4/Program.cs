//Задача 44: Не используя рекурсию, выведите первые N чисел
//Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int InputN(string mess){
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}

void Fibo(int num){
    int prevN = 1;
    int prevPrevN = 0;
    if (num == 1)
    System.Console.WriteLine("0");
    else 
    {
        System.Console.Write("0 1 ");
        for (int i = 3; i <= num; i++)
        {
           int nextFibo = prevN +  prevPrevN;
           System.Console.Write($"{nextFibo} ");
           prevPrevN = prevN;
           prevN = nextFibo;
        }
    }
}

int num = InputN("Введит число:");
Fibo(num);
