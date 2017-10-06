namespace CodePractice.Calculator.Interfaces
{
    public interface ICalc
    {
        int SquareANumber(int number);

        int? SquareANumber(string number);

        double CalculateTax(double baserate, double tax);
    }
}
