namespace Forge.Models.Operators
{
    public struct FloatOperator : IOperator<float>
    {
        public float Add(float a, float b) => a + b;

        public float Subtract(float a, float b) => a - b;

        public float Mul(float a, float b) => a * b;

        public float Div(float a, float b) => a / b;

        public float Cast(int a) => (float) a;

        public float Cast(float a) => a;

        public float Cast(long a) => (float) a;

        public float Cast(double a) => (float) a;

        public float Cast(decimal a) => (float) a;

        public int ConvertToInt(float a) => (int) a;

        public long ConvertToLong(float a) => (long) a;

        public float ConvertToFloat(float a) => a;

        public double ConvertToDouble(float a) => a;

        public decimal ConvertToDecimal(float a) => (decimal) a;

        ///LOGICALS

        public bool Equal(float a, float b) => a == b;

        public bool GreaterThan(float a, float b) => a > b;

        public bool GreaterThanEqual(float a, float b) => a >= b;

        public bool LessThan(float a, float b) => a < b;

        public bool LessThanEqual(float a, float b) => a <= b;

        public bool NotEqual(float a, float b) => a != b;
    }
}
