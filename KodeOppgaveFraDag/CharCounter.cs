namespace KodeOppgaveFraDag;

public class CharCounter
{
    private int CharrCount;
    public int CountChars(string input)
    {
        CharrCount = input.Length;
        return CharrCount;
    }
}