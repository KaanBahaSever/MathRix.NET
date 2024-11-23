class Polynom
{
    private dynamic[] coefficients; //1,2,3,4  = 1 + 2x + 3x^2 + 4x^3
    // 2 4 0 5  = 2 + 4x + 5x^3
    private int length = 0;
    public int Length { get { return length; } }
    private char symbol = 'x';
    public char Symbol { get { return symbol; } set { symbol = value; } }
    public Polynom(int length)
    {
        this.length = length;
        this.coefficients = new dynamic[length];
        for (int i = 0; i < length; i++)
        {
            this.coefficients[i] = 0;
        }
    }
    public Polynom(params dynamic[] coefficients)
    {
        this.coefficients = coefficients;
        this.length = coefficients.Length;
    }

    public dynamic this[dynamic x]
    {
        get { return getValue(x); }
    }
    private static dynamic getValue(dynamic x)
    {
        return x;
    }

    public static Polynom operator +(Polynom a, Polynom b)
    {
        int x = a.coefficients.Length;
        int y = b.coefficients.Length;

        int length = Math.Max(x, y);
        Polynom result = new Polynom(length);

        for (int i = 0; i < length; i++)
        {
            double coef1 = (i < a.coefficients.Length) ? a.coefficients[i] : 0;
            double coef2 = (i < b.coefficients.Length) ? b.coefficients[i] : 0;
            result.coefficients[i] = coef1 + coef2;
        }
        return result;
    }

    public static Polynom operator +(Polynom a, int b)
    {
        a.coefficients[0] += b;
        return a;
    }

    public static Polynom operator *(Polynom a, int b)
    {
        for (int i = 0; i < a.coefficients.Length; i++)
        {
            a.coefficients[i] *= b;
        }
        return a;
    }

    public static Polynom operator -(Polynom a, Polynom b)
    {
        int x = a.coefficients.Length;
        int y = b.coefficients.Length;

        int length = Math.Max(x, y);
        Polynom result = new Polynom(length);

        for (int i = 0; i < length; i++)
        {
            double coef1 = (i < a.coefficients.Length) ? a.coefficients[i] : 0;
            double coef2 = (i < b.coefficients.Length) ? b.coefficients[i] : 0;
            result.coefficients[i] = coef1 - coef2;
        }
        return result;
    }

    public static Polynom operator *(Polynom a, Polynom b)
    {
        int x = a.coefficients.Length;
        int y = b.coefficients.Length;

        Polynom result = new Polynom(x + y - 1);

        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                result.coefficients[i + j] += a.coefficients[i] * b.coefficients[j];
            }
        }
        return result;
    }

    public static Polynom operator /(Polynom a, Polynom b)
    {

        int x = a.coefficients.Length;

        return a;
    }

    //edit
    public static Polynom operator ^(Polynom a, int power)
    {
        Polynom pow_poly = a;
        for (int i = 0; i < power - 1; i++)
        {
            a *= pow_poly;
        }
        return a;
    }
    public static Polynom Pow(Polynom a, int power)
    {
        Polynom pow_poly = a;
        for (int i = 0; i < power - 1; i++)
        {
            a *= pow_poly;
        }
        return a;
    }

    public Polynom Pow(int power)
    {
        if (power == 0)
        {
            return new Polynom(new int[] { 1 });
        }

        Polynom result = new Polynom(this.coefficients);
        Polynom pow_poly = result;
        for (int i = 0; i < power - 1; i++)
        {
            result *= pow_poly;
        }
        return result;
    }
    public Polynom Derivative()
    {
        if (this.coefficients.Length == 1)
        {
            return new Polynom([this.coefficients[0]]);
        }

        Polynom result = new Polynom(this.coefficients);

        return result;
    }

    public double getValue(double x)
    {
        double result = 0;
        for (int i = 0; i < length; i++)
        {
            result += this.coefficients[i] * Math.Pow(x, i);
        }
        return result;
    }

    private string ReplaceFirst(string text, string search, string replace)
    {
        int pos = text.IndexOf(search);
        if (pos < 0)
        {
            return text;
        }
        return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
    }

    public override string ToString()
    {
        string result = "";
        bool isFirstPositive = false;

        for (int i = 0; i < coefficients.Length; i++)
        {
            if (coefficients[i] > 0)
            {
                result += "+" + coefficients[i].ToString() + this.symbol + "^" + i.ToString() + " ";
                if (i == 0) isFirstPositive = true;
            }
            else
            {
                result += coefficients[i].ToString() + this.symbol + "^" + i.ToString() + " ";
            }
        }

        string replacing1 = this.symbol + "^0";
        string replacing2 = this.symbol + "^1";

        result = ReplaceFirst(result, replacing1, "");
        result = ReplaceFirst(result, replacing2, Convert.ToString(this.symbol));

        if (isFirstPositive)
        {
            result = result.Remove(0, 2);
        }

        return string.Format(result);
    }

}