// ========== логический тип bool ===============
// ==== всегда отвечает на вопрос "Да" или "Нет" =======
// ==== истина или ложь ==  true or false ====

//  ===== ПРИМЕР =======  //
/*
bool no = false;
bool yes = true;
System.Console.WriteLine($"5 < 5 : {5 < 5}");
System.Console.WriteLine($"7 < 5 : {7 < 5}");
System.Console.WriteLine($"3 < 5 : {3 < 5}");
System.Console.WriteLine($"5 == 5 : {5 == 5}");
*/

// =========== if else ============= //
/*
int d = 15;
if(d >= 0)
{
    System.Console.WriteLine(">= 0");
}
else if(d < -10)
{
    System.Console.WriteLine("< -10");
}
else // -1...-10
{
    System.Console.WriteLine("-1...-10");
}
*/

// ========== switch =========== //
/*
int d = 1;
switch (d)
{
    case 0:
         System.Console.WriteLine("ноль");
         break;
    case 1:
         System.Console.WriteLine("один");
         break;
    case 2:
         System.Console.WriteLine("два");
         break;
    default:
        System.Console.WriteLine("Другое число");
        break;
}
*/

// ==== ПРИМЕР ==== //
/*
System.Console.WriteLine("Введите Ваше имя: ");
string name = Console.ReadLine();

switch(name)
{
    case "Степан":
        name = "Стёпа!";
        break;
    case "Алексей":
        name = "Лёха!";
        break;
    default:
    break;
}
System.Console.WriteLine($"Привет, {name}");
*/

// ========= && - И ,|| - ИЛИ , ! - НЕ или инверсия ========== //

int money = 100;
int minPrice = 20;
/*  0---5----10-------20--------100---------бесконечность */
System.Console.Write("Введите цену товара:");
int price = int.Parse(Console.ReadLine());

System.Console.WriteLine();
System.Console.WriteLine("Вариант 1 - && логическое И");

// Покупаем все товары от 20 до 100 рублей
if(minPrice <= price && price <= money)
{
    System.Console.WriteLine("Покупаем!");
}
else
{
    System.Console.WriteLine("Не покупаем.");
}


System.Console.WriteLine();
System.Console.WriteLine("Вариант 2 - || логическое ИЛИ");
// товары меньше 20 руб или товары больше 100 руб не подходят 
if(  price < minPrice || price > money)
{
    System.Console.WriteLine("Не Покупаем!");
}
else
{
    System.Console.WriteLine("Покупаем.");
}

System.Console.WriteLine();
System.Console.WriteLine("Вариант 3 - ! НЕ и || логическое ИЛИ");
// все товары кроме товаров меньше 20 руб или кроме товаров больше 100 руб покупаем
if(!( price < minPrice || price > money))
{
    System.Console.WriteLine("Покупаем!");
}
else
{
    System.Console.WriteLine("Не покупаем.");
}





