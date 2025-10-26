int a = 3;
int b = 4;
int c = 5;
int d = 6;

for (int i = 1; i < 4; i++)
{
    b ++;
    a += b;
    c += a;
    d = (c-a)+i;
}
Console.WriteLine(d);