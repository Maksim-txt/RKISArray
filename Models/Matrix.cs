namespace Models;

public class Matrix
{
    public static int Count = 0;
    private int _id;
    private int _rows;
    private int _columns;

    public int[] array = new int[3 * 3];

    public int Id
    {
        get => _id;
    }

    public int Columns
    {
        get => _columns;
        set
        {
            _columns = value;
            array = new int[_rows * _columns];
        }
    }

    public int Rows
    {
        get => _rows;
        set
        {
            _rows = value;
            array = new int[_rows * _columns];
        }
    }

    public Matrix(int rows, int columns)
    {
        array = new int[rows * columns];
        _rows = rows;
        _columns = columns;
        Count += 1;
        _id = Count;
    }

    public Matrix()
    {
        Count += 1;
        _id = Count;
    }
}