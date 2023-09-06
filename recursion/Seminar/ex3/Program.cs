//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
int InputN(string mess){
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}
String ConvertToBin(int num){
    string result = "";
    while(num != 0){
        int temp = num%2;
        result = $"{temp}" + result; 
        num /= 2;
    }
    return result;
}

int number = InputN("Введите число:");
System.Console.WriteLine(ConvertToBin(number));

