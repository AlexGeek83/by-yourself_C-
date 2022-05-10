// ======== Многомерные массивы =========== //
#region 
/*
// == 2-мерный массив ==//
int[,] nTable = new int[3,3]
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

// === 3D массив === 3-х мерный/ объемный в виде куьа ниже ==== //
double[,,]array3D = new double[3, 3, 3];

array3D[0, 0, 0] = 0.5;
array3D[0, 0, 1] = 0.9;
array3D[1, 1, 1] = 1.2;


// ==== зубчатый массив ====== //

byte[][] months = new byte[12][];
months[0] = new byte[31]; // январь
months[1] = new byte[28]; // февраль
months[2] = new byte[31]; // март
//....
months[11] = new byte[31]; // декабрь

*/
#endregion

// === таблица умножения 5 * 5 === //

int n = 10; // размерность таблицы умножения
int[,]table = new int[n,n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        table[i,j] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < n; i++)
{
    System.Console.Write($" \t {i + 1}");
}
System.Console.WriteLine();

for (int i = 0; i < n; i++)
{
    System.Console.Write($" {i + 1}");
    for (int j = 0; j < n; j++)
    {
        System.Console.Write($"\t {table[i,j]}");
    }
    System.Console.WriteLine();
}
Console.ReadLine();



