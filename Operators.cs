namespace Forge.Models.Operators
{

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
