// Игра в пирамидки

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) //Сделаем шпиль рабочим string with и возьмём из него
//текущий блинчик. Вторым аргументом передадим шпиль string on, на котором должна оказаться пирамидка. 
//Далее дадим название нашему промежуточному шпилю string some, потому что всего их по умолчанию три, и укажем, 
//какое количество блинов есть всего int count. Аналогичным образом мы можем взять, например, четыре шпиля, указать в качестве аргумента 4 count.

{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
