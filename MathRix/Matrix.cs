
class Matrix
{
    private dynamic matrix;
    int rowCount;
    int columnCount;
    public Matrix(dynamic[,] matrix)
    {
        this.matrix = matrix;
        rowCount = matrix.GetLength(0);
        columnCount = matrix.GetLength(1);
    }
    public Matrix(int row, int column, int value = 0)
    {
        rowCount = row;
        columnCount = column;

        this.matrix = new dynamic[row,column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                matrix[i, j] = value;
            }
        }
    }

    public dynamic this[int row, int column]
    {
        get { return matrix[row, column]; }
        set { matrix[row, column] = value; }
    }
    public bool isSquareMatrix() => rowCount == columnCount;

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.rowCount == b.rowCount && a.columnCount == b.columnCount)
        {
            for (int i = 0; i < a.rowCount; i++)
            {
                for (int j = 0; j < a.columnCount; j++)
                {
                    a.matrix[i, j] += b.matrix[i, j];
                }
            }
        }
        return a;
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.rowCount != b.rowCount || a.columnCount != b.columnCount)
        {
            throw new ArgumentException("");
        }

        for (int i = 0; i < a.rowCount; i++)
        {
            for (int j = 0; j < a.columnCount; j++)
            {
                a.matrix[i, j] -= b.matrix[i, j];
            }
        }
        return a;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.rowCount == b.columnCount)
        {
            for (int i = 0; i < a.rowCount; i++)
            {
                for (int j = 0; j < a.columnCount; j++)
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

        for (int i = 0; i < rowCount; i++)
        {
            result += "\n";
            for (int j = 0; j < columnCount; j++)
                result += this[i, j] + " ";
        }
        return String.Format(result);
    }

}