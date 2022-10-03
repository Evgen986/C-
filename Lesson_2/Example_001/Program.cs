int Max (int arg1, int arg2, int arg3)
{
    int max = arg1;
    if(arg2>max) max = arg2;
    if(arg3>max) max = arg3;
    return max;
}

int a1 = 35,
    b1 = 48,
    c1 = 58,
    a2 = 2,
    b2 = 75,
    c2 = 65,
    a3 = 1235,
    b3 = 48,
    c3 = 58;

int result = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine("Максимальное число: " + result);