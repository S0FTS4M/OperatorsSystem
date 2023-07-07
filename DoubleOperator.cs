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
}
