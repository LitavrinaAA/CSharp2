// Задача 40: Напишите программу, которая принимает на вход три числа и
//проверяет, может ли существовать треугольник с сторонами такой длины.
int InputSide(string mess){
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}

bool IsTfiangle(int a, int b, int c){
    return(a + b > c && a + c > b && b + c > a);
}

int a = InputSide("Input length first side: ");
int b = InputSide("Input length second side: ");
int c = InputSide("Input length third side: ");

Console.Write($" Cуществует такой треугольник: {IsTfiangle(a, b, c)}");