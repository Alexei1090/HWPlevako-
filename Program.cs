using System;
Console.Clear();

string[] array = {"hello", "2", "world", ":-)"};
Console.WriteLine(Met(array));


string[] m = Met(array).Split(' ');
Console.WriteLine(m);


string Met(string[] arr)
{
    string st = "";
    int i = 0;
    int j = arr.Length - 1;
    while(i<=j)
    {
        if(arr[i].Length <= 3)
        {
            st = st + $"{arr[i]} ";
            i = i + 1;
        }
        else
        {
            i = i + 1;
        }
    }
    return st;
}
