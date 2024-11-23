// See https://aka.ms/new-console-template for more information
// Assuming the Matrix class is in a separate namespace or file
// Replace with the actual namespace where Matrix<T> is defined

Console.WriteLine("Hello, World!");

/* Polynom a = new Polynom(-1, 2, 3, 4, 5, 6, 23, -54, -23, 12, 54, 23, 54, 76);
Polynom b = new Polynom(2, 3, 4); //2x^0 3x^1 4x^2
Polynom c = new Polynom(1, 2, 3);
Polynom e = new Polynom(3);

Polynom[] mt3 = new Polynom[] { b, b, b };
Polynom[] mt4 = new Polynom[] { c, c, c }; */


int[,] mt = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };
int[,] mt2 = new int[3, 3] { { 1, 2, 3 }, { 2, 3, 4 }, { 3, 4, 5 } };

//List<Complex<int>> a = new List<Complex<int>>() { new Complex<int>(1, 2), new Complex<int>(3, 4), new Complex<int>(5, 6) };

//Polynomial<Complex<int>> f = new Polynomial<Complex<int>>();

//Print(f);

int[] source = new int[4] { 12, 3, 5, 7 };
int[] destination = new int[3];
Array.Copy(source, 1, destination, 0, source.Length - 1);
//Array.Copy(source, 1, destination, 0, source.Length - 1);

Matrix a = new Matrix(2,2);
Matrix b = new Matrix(2,2);

a[0, 0] = new Complex(1, 2);
a[0, 1] = new Complex(2, 3);
a[1, 0] = new Complex(3, 4);
a[1, 1] = new Complex(4, 5);

b[0, 0] = new Complex(1, 2);
b[0, 1] = new Complex(2, 3);
b[1, 0] = new Complex(3, 4);
b[1, 1] = new Complex(4, 5);

Print(a+b);


static void Print(dynamic a)
{
    if (a.GetType().IsArray)
    {
        Console.WriteLine("[" + string.Join(',', a) + "]");
    }
    else
    {
        Console.WriteLine(a);
    }

}

