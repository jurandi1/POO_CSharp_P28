﻿using POO_CSharp_P28.Services;

delegate void BinaryNumericOperation(double n1, double n2);

internal class Program
{
    private static void Main(string[] args)
    {

        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.ShowSum;
        op += CalculationService.ShowMax;

        op.Invoke(a, b);
    }
}