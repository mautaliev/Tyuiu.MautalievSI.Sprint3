int a = 6;
int b = 4;
int c = 8;
int d = 7;
int i = 1;

do
{
    b++;
    b = a + c;
    c = b - a;
    d = (a - c) - i;
    i++;
}
while (i < 4);

Console.WriteLine(d);
Console.WriteLine(d);