﻿// Вид4 метода. Что-то принимают, что-то возвращают
string Method4(int count, string c)  // выбрали string так как возвращать хотим строку. в скобках указали аргументы string - это символ, то есть на выходе символ с будет показывать count(количество) раз
{
    int i = 0; // присваиваем i для старта нашего цикла
    string result = String.Empty; // переменная куда будем класть наш конечный результат. Значение для начала пустая строка String.Empty

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result; // возвращает нам результат который мы ожидаем получить из метода
}
string res = Method4(10, "asdf"); // чтобы вызвать наш метод нам нужно создать нужную нам переменную в данном слукчае res, и в скобках указываем количество раз и текст который будем склеивать 10 раз.
Console.WriteLine(res); // и показываем на экране результат наш склеенный 10 раз.