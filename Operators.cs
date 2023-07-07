namespace Forge.Models.Operators
{

    public struct DoubleOperator : IOperator<double>
    {
        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;

        public double Mul(double a, double b) => a * b;

        public double Div(double a, double b) => a / b;

        public double Cast(int a) => (double) a;

        public double Cast(long a) => (double) a;

        public double Cast(float a) => (double) a;

        public double Cast(double a) => a;

        public double Cast(decimal a) => (double) a;

        public int ConvertToInt(double a) => (int)a;
        
        public long ConvertToLong(double a)=> (long)a;

        public float ConvertToFloat(double a)=> (float)a;

        public double ConvertToDouble(double a)=> a;
        
        public decimal ConvertToDecimal(double a)=> (decimal)a;

        ///LOGICALS

        public bool Equal(double a, double b) => a == b;

        public bool GreaterThan(double a, double b) => a > b;

        public bool GreaterThanEqual(double a, double b) => a >= b;

        public bool LessThan(double a, double b) => a < b;

        public bool LessThanEqual(double a, double b) => a <= b;

        public bool NotEqual(double a, double b) => a != b;
    }

    public struct LongOperator : IOperator<long>
    {
        public long Add(long a, long b) => a + b;

        public long Subtract(long a, long b) => a - b;

        public long Mul(long a, long b) => a * b;

        public long Div(long a, long b) => a / b;

        public long Cast(int a) => (long) a;

        public long Cast(long a) => a;

        public long Cast(float a) => (long) a;

        public long Cast(double a) => (long) a;

        public long Cast(decimal a) => (long) a;

        public int ConvertToInt(long a)=> (int)a;

        public long ConvertToLong(long a)=> a;

        public float ConvertToFloat(long a) => (float)a;

        public double ConvertToDouble(long a)=> (double)a;

        public decimal ConvertToDecimal(long a)=> (decimal)a;

        ///LOGICALS

        public bool Equal(long a, long b) => a == b;

        public bool GreaterThan(long a, long b) => a > b;

        public bool GreaterThanEqual(long a, long b) => a >= b;

        public bool LessThan(long a, long b) => a < b;

        public bool LessThanEqual(long a, long b) => a <= b;

        public bool NotEqual(long a, long b) => a != b;
    }

    public struct DecimalOperator : IOperator<decimal>
    {
        public decimal Add(decimal a, decimal b) => a + b;

        public decimal Subtract(decimal a, decimal b) => a - b;

        public decimal Mul(decimal a, decimal b) => a * b;

        public decimal Div(decimal a, decimal b) => a / b;

        public decimal Cast(int a) => a;

        public decimal Cast(long a) => a;

        public decimal Cast(float a) => (decimal) a;

        public decimal Cast(double a) => (decimal) a;

        public decimal Cast(decimal a) => a;

        public int ConvertToInt(decimal a) => (int) a;

        public long ConvertToLong(decimal a) => (long) a;

        public float ConvertToFloat(decimal a) => (float) a;

        public double ConvertToDouble(decimal a) => (double) a;

        public decimal ConvertToDecimal(decimal a) => a;

        ///LOGICALS

        public bool Equal(decimal a, decimal b) => a == b;

        public bool GreaterThan(decimal a, decimal b) => a > b;

        public bool GreaterThanEqual(decimal a, decimal b) => a >= b;

        public bool LessThan(decimal a, decimal b) => a < b;

        public bool LessThanEqual(decimal a, decimal b) => a <= b;

        public bool NotEqual(decimal a, decimal b) => a != b;
    }
}
