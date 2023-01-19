// See https://aka.ms/new-console-template for more information

string[,] table = new string [2, 5];  // тип данных string. в скобках 2 это кол-во строк, 5 это кол-во столбцов
// String.Empty инициализация для строк происходит такой командой
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]
/*table[1, 2] = "слово";  // наименование массива, 1 это обращаемся к строке 1, и 2 ко второму столбцу

for(int rows = 0; rows < 2; rows++)  // счётчик rows и гоняем до двух строк, то есть ставим rows<2.
{
    for(int columns = 0; columns < 5; columns++) // а это счетчик для столбцов
    {
        Console.WriteLine($"-{table[rows, columns]}-");
    }
}
*/


  // делаем метод который будет печатать нашу матрицу и заполнять её числами
void PrintArray(int[,] matr) // в качестве аргументов мы передаём нашу таблицу чисел
{
    for(int i = 0; i < matr.GetLength(0); i++) // счётчик щёлкающий строки. Вместо размера строк в массиве, вместо цифры 3 i<3, мы можем указать имя массива matrix и добавить функцию GetLength(0), 0 это место нашей тройки индекс так называемый двумерного массива.  
    {
        for(int j = 0; j < matr.GetLength(1); j++) // счётчик щёлкающий столбцы. а здесь в скобках указываем 1, так как в нашем двумерном массиве 4 стоит под индексом 1.
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}

void FillArray(int[,] matr)  // делаем метод который будет заполнять нашу матрицу случайными числами
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);  // тут обращаемся к i и j то есть к строке и столбцу и при помощи генератора случайных чисел заполняем строки и столбцы от 1 до 10(до 9, 10 не включительно)
        }
    }
}

int[,] matrix = new int[3, 4];  // теперь сделаем то же самое но с числами. Определяем двумерный массив называем его matrix

PrintArray (matrix);
FillArray (matrix);
Console.WriteLine();
PrintArray (matrix);