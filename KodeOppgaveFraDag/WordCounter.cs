namespace KodeOppgaveFraDag;

public class WordCounter
{
    private int count = 0;

    public int countWords(string[] list)
    {
        foreach (var word in list)
        {
            count++;
        }
        return count;
    }
}