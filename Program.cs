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