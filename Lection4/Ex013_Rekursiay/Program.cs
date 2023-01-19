// See https://aka.ms/new-console-template for more information

double Factorial (int n) // используем тип double так как факториал 17 уже не показывает нормальный результат. Так как при типе int мы получим отрицательные числа.

{
    // 1! = 1
    //0! = 1
    if(n == 1) return 1;
    else return n * Factorial(n-1);
}
for(int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
