﻿// Вид3 метода. Ничего не принимают, что-то возвращают
int Method3() // указываем тип данных который мы хотим получать на выходе, в скобках ничего не указываем, так как ничего не принимают
{
    return DateTime.Now.Year;
}
int year = Method3(); //присваиваем идентификатор для переменной year
Console.WriteLine(year); //и здесь уже ипользуем эту переменную на выходе