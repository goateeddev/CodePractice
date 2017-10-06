namespace CodePractice.Calculator.Interfaces
{
    public interface IFormatter
    {
        int? StringToInt(string s);

        int?[] StringArrayToIntArray(string[] s);
    }
}
