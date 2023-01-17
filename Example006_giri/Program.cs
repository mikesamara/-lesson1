int a= 1;
int b= 3;
int c= 5;
int d= 8;
int i= 2;

int max = a;

if (a>max) max=a; // сравниваем максимальное число с весом гири 
if (b>max) max=b;
if (c>max) max=c;
if (d>max) max=d;
if (i>max) max=i;

Console.Write("max=");
Console.WriteLine(max);