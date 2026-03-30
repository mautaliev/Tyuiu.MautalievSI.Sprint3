int x;
int sumd = 0;

for (x = 5; x <= 10; x++)
{
    for (int d = 1; d <= x; d++)
    {
        if (x % d == 0)
        {
            if (d > 5)
            {
                sumd = sumd + d;
            }
        }
    }
}

Console.WriteLine(sumd);