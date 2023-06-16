namespace Forge.Models.Operators
{
    public interface IOperator<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Mul(T a,T b);
        T Div(T a, T b);
        T Cast(int a);
        T Cast(long a);
        T Cast(float a);
        T Cast(double a);
        T Cast(decimal a);

        int ConvertToInt(T a);
        long ConvertToLong(T a);
        float ConvertToFloat(T a);
        double ConvertToDouble(T a);
        decimal ConvertToDecimal(T a);

        bool LessThan(T a,T b);
        bool LessThanEqual(T a, T b);
        bool GreaterThan(T a, T b);
        bool GreaterThanEqual(T a, T b);
        bool Equal(T a, T b);
        bool NotEqual(T a, T b);
    }
}