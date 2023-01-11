﻿/* Задача: алгоритм сортировки методом выбора, ещё его называют алгоритм сортировки методом минимакса или
иногда просто называют методом максимального, или выбора максимального или выбора
минимального и так далее. выбрать самый первый элемент и в оставшейся
части, с учётом нашей текущей позиции определить минимальный. После того как он найден,
нужно поменять выделенный (рабочий элемент), на который сейчас указывает стрелочка, это
6, с единицей, являющейся для нас минимальной, в общем, выделенном куске

1. Найти позицию минимального элемента в неотсортированной части массива.
2. Произвести обмен этого значения со значением первой неотсортированной позиции.
3. Повторять пока есть неотсортированные элементы. */

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 }; // присваиваем массив с числами

void PrintArray(int[] array)  // Метод который будет выводить наш массив. в качестве аргумента метода будет приходить массив int[] array
{
    int count = array.Length; // присваиваем количество элементов в массиве длина массива

    for (int i = 0; i < count; i++) // цикл for для пробежки по всем элементам массива
    {
        Console.Write($"{array[i]} "); // выводим наш первоначальный массив на экран. Write чтобы не переносил на новую строку а выдал результат в одной строке
    }
    Console.WriteLine(); // после вывода нашего массива выводим пустую строку
}

void SelectionSort(int[] array)  // пишем метод который будет упорядочивать наш массив
{
    for (int i = 0; i < array.Length - 1; i++)  // здесь мы уже задаём условие к длине массива array.Length. -1 ставим так как максимальное ищем от i+1.
    {
        int minPosition = i; // определяем ту позицию на которую смотрим и задаём ей i, то есть с нулевого элемента.

        for (int j = i + 1; j < array.Length; j++) // ищем наш максимальный элемент, от начальной позиции i прибавляем 1 и так по всей длине массива
        {
            if (array[j] < array[minPosition]) minPosition = j; // здесь уже сравниваем если элемент i+1 меньше мин позиции, то в мин позицию присваиваем его
        }

        int temp = array[i]; // присваиваем временную переменную для смены местами элементов
        array[i] = array[minPosition]; // в i-ую позицию подставляем мин позицию
        array[minPosition] = temp; // мин позицию ставим во временную
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);