// Собрать строку с числами от a до b, a ≥ b. от меньшего к большему.

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--) //тут меняем местами а и б и меняем условие больше равно
    {
        result += $"{i} ";
    }
    return result;
}
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersFor(1, 10)); // 10 9 8 7 6 5 4 3 2 1
Console.WriteLine(NumbersRec(1, 10)); // 10 9 8 7 6 5 4 3 2 1
