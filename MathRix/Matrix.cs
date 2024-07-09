
class Matrix
{
    private dynamic matrix;
    int row_count;
    int col_count;
    public Matrix(int[,] matrix)
    {
        this.matrix = matrix;
        row_count = matrix.GetLength(0);
        col_count = matrix.GetLength(1);
    }

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
        row_count = matrix.GetLength(0);
        col_count = matrix.GetLength(1);
    }

    public Matrix(float[,] matrix)
    {
        this.matrix = matrix;
        row_count = matrix.GetLength(0);
        col_count = matrix.GetLength(1);
    }
    public Matrix(int row, int column, int value = 0, string type = "int")
    {
        row_count = row;
        col_count = column;

        matrix = new double[row, column];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = value;
            }
        }
    }
    public Matrix(Polynom[,] matrix)
    {
        this.matrix = matrix;
    }

    public dynamic this[int row, int column]
    {
        get { return matrix[row, column]; }
        set { matrix[row, column] = value; }
    }

    public bool isSquareMatrix()
    {
        return true;
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.row_count == b.row_count && a.col_count == b.col_count)
        {
            for (int i = 0; i < a.row_count; i++)
            {
                for (int j = 0; j < a.col_count; j++)
                {
                    a.matrix[i, j] += b.matrix[i, j];
                }
            }
        }
        return a;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.row_count == b.row_count && a.col_count == b.col_count)
        {
            for (int i = 0; i < a.row_count; i++)
            {
                for (int j = 0; j < a.col_count; j++)
                {
                    a.matrix[i, j] -= b.matrix[i, j];
                }
            }
        }
        else
        {
            throw new ArgumentException("");
        }
        return a;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.row_count == b.col_count)
        {
            for (int i = 0; i < a.row_count; i++)
            {
                for (int j = 0; j < a.col_count; j++)
                {
                    a.matrix[i, j] -= b.matrix[i, j];
                }
            }
        }
        else
        {
            throw new ArgumentException("");
        }
        return a;
    }

    public override string ToString()
    {
        string result = "";

        for (int i = 0; i < row_count; i++)
        {
            result += "\n";
            for (int j = 0; j < col_count; j++)
                result += this[i, j] + " ";
        }
        return String.Format(result);
    }

}