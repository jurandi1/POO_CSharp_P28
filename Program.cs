using POO_CSharp_P28.Services;

delegate double BinaryNumericOperation(double n1, double n2);

internal class Program
{
    private static void Main(string[] args)
    {

        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.Max;

        double result = op(a, b);
        Console.WriteLine(result);
    }
}