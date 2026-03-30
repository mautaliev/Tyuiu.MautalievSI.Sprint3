string str = "Gfvsvm sdefg cvdffgg vgrtg";
int count = 0;

foreach (char ch in str)
{
    if (ch == 'g')
    {
        count++;
    }
}

Console.WriteLine(count);