// Собрать строку с числами от a до b, a ≤ b. от меньшего к большему.

string NumbersFor(int a, int b) // итеративный способ
{
    string result = String.Empty;
    for (int i = a; i <= b; i++) // Запускаем цикл, который будет менять счётчик от значения а, меньшим или равным б
    {
        result += $"{i} "; // собирает в результирующую строку конкретное значение
    }
    return result;
}

string NumbersRec(int a, int b) // при помощи рекурсии
{
    if (a <= b) return $"{a} " + NumbersRec(a + 1, b+1); // используя рекурсию, надо прописать условие окончания рекурсии в else.
    else return String.Empty; // окончание рекурсии. если условие не выполнилось возвращаем пустую строку
}

// здесь мы заносим наши значения а и б
Console.WriteLine(NumbersFor(1, 10)); 
Console.WriteLine(NumbersRec(1, 10)); 

// в результате получим 1 2 3 4 5 6 7 8 9 10