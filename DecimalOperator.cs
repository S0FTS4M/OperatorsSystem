namespace Forge.Models.Operators
{
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
