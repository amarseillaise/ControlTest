static string [] LessThanThree(string[] Arr)
{
    int Count = 0 ;
    foreach (var s in Arr)
    {
        if (s.Length <= 3) Count++;
    }
    string [] NewArr = new string[Count];
    int Index = 0;
    foreach(var g in Arr)
    {
        if (g.Length <= 3)
        {
            NewArr[Index] = g;
            Index++;
        }
    }
    return NewArr;
}

string [] Massive = new string [5];
for (int j = 0; j < Massive.Length; j++)
{
    Console.Write($"Введите {j + 1} элемент: ");
    Massive[j] = Console.ReadLine();
}
string [] NewMassive = new string [LessThanThree(Massive).Length];
Array.Copy(LessThanThree(Massive), NewMassive, LessThanThree(Massive).Length);
Console.WriteLine("Исходный массив: ");
foreach (var v in Massive) Console.Write($"{v} ");
Console.WriteLine("");
Console.WriteLine("Новый массив: ");
foreach (var v in NewMassive) Console.Write($"{v} ");