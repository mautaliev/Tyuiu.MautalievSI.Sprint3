int x;
double sp = 1;
int i = 0;

for (x = -2; x <= 2; x++)
{
    if (x == 0)
    {
        continue;
    }

    sp = sp * (2 * x + 2);
    i++;
}

Console.WriteLine(sp);