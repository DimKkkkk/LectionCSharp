/* Посчитаем Фибоначчи при помощи итеративного способа и рекурсии и увидим минусы рекурсии, 
сколько операций она делает по сравнению с итеративным способом. 

По результату мы увидим, что на маленьких значениях рекурсия быстрее, но когда значения больше 30, то рекурсия начинает выполнять дольше.
*/
Console.Write("Введите число начала: ");
int start = GetNumberFromUser();
Console.Write("Введите число конец: ");
int end = GetNumberFromUser();
decimal fRekursiya = 0; // переменная для подсчёта вызова количества раз рекурсии
decimal fIterative = 0; // переменная для подсчёта вызова количества раз итерации

int GetNumberFromUser()
{
    while(true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect) return num;
        else Console.WriteLine("Ошибка ввода");
    }
}

decimal FibonacciRecursiya(int n)
{
    fRekursiya++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursiya(n - 1) + FibonacciRecursiya(n - 2);
}

decimal FibonacciIterative(int n)
{
    fIterative++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;
        f0 = f1;
        f1 = result;
        fIterative++;
    }
    return result;
}

//Console.ReadLine(); // это для того чтобы по нажатию клавиши начинался подсчёт

DateTime dt = DateTime.Now; // посчитаем сколько времени уходит на подсчёт. ставим время до начала подсчёта и запомним его
for (int n = start; n < end; n++) //цикл для подсчёта  от 10 до 40 будем показывать
{
    Console.WriteLine($"FibonacciIterative({n}) = {FibonacciIterative(n)} fIterative = {fIterative.ToString("### ### ###"),-10}"); 
    /* fIterative.ToString("### ### ###"),-10 - Сделаем более красивую маску — мы сильно вылетим за пределы, и будет горизонтальная прокрутка, 
    зато наглядно. Поставлю минус, чтобы стало чуть красивее. Укажем 15, чтобы числа были друг под другом. */
    fIterative = 0; // после того как посчитали первое число обнуляем счётчик вызова итераций
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds); // и покажем после операций разницу между временем окончания и временем начала в милисекундах

Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for (int n = start; n < end; n++)// от 10 до 40 будем показывать
{
    Console.WriteLine($"FibonacciRecursiya({n}) = {FibonacciRecursiya(n)} fRekursiya = {fRekursiya.ToString("### ### ###"),-10}");
    fRekursiya = 0; // после того как посчитали первое число обнуляем счётчик количества вызова рекурсионного способа
}
Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
//Console.ReadLine();