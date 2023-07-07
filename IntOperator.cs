namespace Forge.Models.Operators
{
    public struct IntOperator : IOperator<int>
    {
        public int Add(int a, int b) => a + b;

        public int Subtract(int a, int b) => a - b;

        public int Mul(int a, int b) => a * b;

        public int Div(int a, int b) => a / b;

        public int Cast(int a) => a;

        public int Cast(long a) => (int) a;

        public int Cast(float a) => (int) a;

        public int Cast(double a) => (int) a;

        public int Cast(decimal a) => (int) a;

        public int ConvertToInt(int a) => a;

        public long ConvertToLong(int a) => a;

        public float ConvertToFloat(int a) => (float)a;

        public double ConvertToDouble(int a) => a;

        public decimal ConvertToDecimal(int a) => a;

        ///LOGICALS

        public bool Equal(int a, int b) => a == b;

        public bool GreaterThan(int a, int b) => a > b;

        public bool GreaterThanEqual(int a, int b) => a >= b;

        public bool LessThan(int a, int b) => a < b;

        public bool LessThanEqual(int a, int b) => a <= b;

        public bool NotEqual(int a, int b) => a != b;
    }
}
