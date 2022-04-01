// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*int Add(int a, int b)
{
    return a + b;
}
int subt(int a, int b)
{
    return (a - b);
}
int mul(int a, int b)
{
    return a * b;
}
double div(int a, int b)
{
    if (b == 0)
        return -1;
    return (double)a / b;
}*/

Console.WriteLine("Enter the Ist No.: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the 2nd No. :");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Press 1 for Addition.\nPress 2 for Subtraction.\nPress 3 for Multiplication.\nPress 4 for Division\n");
Console.WriteLine("Enter the operation needed to be performed: ");
int op=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result: ");
switch (op)
{
    case 1:
        Console.WriteLine(a+b);
        break;
    case 2:
        Console.WriteLine(a-b);
        break;
    case 3:
        Console.WriteLine(a*b);
        break;
    case 4:
        //Console.WriteLine(div(a, b));
        Console.WriteLine((double)a/b);
        break;
    default:
        Console.WriteLine("Invalid selection!");
        break;

}
