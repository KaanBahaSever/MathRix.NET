// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Polynom a = new Polynom("λ", -1, 2, 3, 4, 5, 6, 23, -54, -23, 12, 54, 23, 54, 76);
Polynom b = new Polynom(2, 3, 4); //2x^0 3x^1 4x^2
Polynom e = new Polynom(3);

int[,] mt = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
int[,] mt2 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
Polynom[] mt3 = new Polynom[] { a, b, e };

Matrix c = new Matrix(mt);
Matrix d = new Matrix(mt2);

int[] source = new int[4] { 12, 3, 5, 7 };
int[] destination = new int[3];
Array.Copy(source, 1, destination, 0, source.Length - 1);
//Array.Copy(source, 1, destination, 0, source.Length - 1);

Console.WriteLine(a.ToString());

static void Print(dynamic a)
{
    if (a.GetType().IsArray)
    {
        Console.WriteLine("["+string.Join(',',a)+"]");
    }
    else
    {
        Console.WriteLine(a);
    }

}

Print(destination);