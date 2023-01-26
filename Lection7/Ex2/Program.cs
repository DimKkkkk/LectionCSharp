// требуется найти сумму чисел от 1 до n.

int SumFor(int n) // Самый простой способ — итеративный
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i; //Берём цикл от 1 до числа, которое указано, в нашем случае — n, и собираем всё
//в некую переменную result
    return result;
}

int SumRec(int n) // Если использовать рекурсию,  
{
    if (n == 1) return 1; // потребуется прописать условия выхода, а условие выхода здесь — n, равное 1. либо 0 если от нуля
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10)); // 55
Console.WriteLine(SumRec(10)); // 55