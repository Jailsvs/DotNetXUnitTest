namespace ConsoleCalc
{
    public class Calc
    {
        public static double Sum(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }
        public static double Subtract(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }
        public static double Multiply(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }
        public static double Divide(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }
        public static bool IsEvenNumber(int numero)
        {
            return numero % 2 == 0;
        }
    }
}
