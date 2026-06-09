
namespace Calculation{
    public delegate double MathOperation(double a, double b);

    public class MathEngine{

        public double Add(double a, double b){
            return a + b;
        }

        public double Subtract(double a, double b){
            return a - b;
        }

        public double Multiply(double a, double b){
            return a * b;
        }

        public double Divide(double a, double b){
            if(b != 0)
                return a / b;
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

    }
}