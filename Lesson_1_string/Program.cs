// изучаем строки

char c = 'a'; // один символ или 2 байта
/*   ==========================================
string str = "Пример строки"; 
System.Console.WriteLine($"длина строки (Пример строки) равна {str.Length} символам");
System.Console.WriteLine($"Размер строки {str.Length*2} байт");
*/ //============================================

//string t1 = "Привет ";  //складываем элементы в строку 
//string t2 = "мир!";  //складываем элементы в строку 

//string t12 = t1 + t2 + "!!!!";  //складываем элементы в строку 
//System.Console.WriteLine(t12);  //складываем элементы в строку и выводим на экран

//string userInput = Console.ReadLine(); // считываем строку
//System.Console.WriteLine(userInput);  // выводим на экран
//===============///////===================
//небезопасное преобразование - может вызвать ошибку при вводе букв и тп 
//int input = int.Parse(userInput); // преобразовываем символ в число
//System.Console.WriteLine(input);
//=================////////=================
//int input;
   //int.TryParse(userInput, out input); //безопасно преобразовываем символы в строку
//int.TryParse("14" + "77", out input); // int.TryParse - перевод в цифру
//System.Console.WriteLine(input*2);

//=========== наоборот из числа в строку  ============
//int age = 20;
//string q = "Вам " + 20 + " лет";  // или string q = "Вам " + 20 + " лет";
    //string q2 = age.ToString(); // из чисоа снова в строку или age + "";

//System.Console.WriteLine(q);

// ============ фишки со строкой ============
int age = 20;
string q = "Вам " + 20 + " лет";  // или string q = "Вам " + 20 + " лет";

System.Console.WriteLine(q.Substring(4,2));  // вытащить определенный элемент из строки
// подстроку, в данном случае вытащили значение 20
System.Console.WriteLine(q.IndexOf("20"));   // ищем в массиве букв индекс подстроки - т.е с какого индекса начинается заданное число
System.Console.WriteLine(q.ToLower());   // все буквы маленькие - нижний регистр

//======== задаем пустую строку ========
string.IsNullOrEmpty("11");
string.IsNullOrEmpty("");  //положили ничего, но память уже выделена

string ddd = null;  // пустота, ничего и память не выделена, нет данных


