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
}
