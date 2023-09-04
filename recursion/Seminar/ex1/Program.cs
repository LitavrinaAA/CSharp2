// Задача 39: Напишите программу, которая перевернёт одномерный
//массив (последний элемент будет на первом месте, а первый - на
//последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int InputInteger(string mess){
    System.Console.WriteLine(mess);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateDoubleArr(int size)
{
    return new double[size];
}

void FillDoubleArr(double[] arr, int minV, int maxV)
{
    Random rnd = new Random();
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble(), 2);
    }
}
void PrintArr (double[] arr){
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        System.Console.Write($" {arr[i]} ");
    }
    System.Console.WriteLine();
}
int size = InputInteger("Введите размер массива: ");
int minV = InputInteger("Введите максимальное значение эелемента: ");
int maxV = InputInteger("Введите минимальное значение элемента: ");
double[] arrD = CreateDoubleArr(size);
FillDoubleArr(arrD, minV, maxV);
PrintArr(arrD);