// Факториал числа. Произведение чисел от 1 до n.

int FactorialFor(int n) //описываем функцию, принимающую значение того самого n, факториал которого требуется найти
{
    int result = 1; // результирующую переменную, по умолчанию будет нейтральный по умножению элемент — 1
    for (int i = 1; i <= n; i++) result *= i; //Далее идёт цикл от 1 до момента, пока i меньше или равно n.
    return result;
}

int FactorialRec(int n)
{
    if (n == 1) return 1; // обязательное условие выхода — то, что n, аргумент нашей функции, стал равен 1
    else if (n == 0) return 1; // и 0 тоже, так как 0! = 1 тоже
    else return n * FactorialRec(n - 1);
}

Console.WriteLine(FactorialFor(5)); // 3628800
Console.WriteLine(FactorialRec(5)); // 3628800
