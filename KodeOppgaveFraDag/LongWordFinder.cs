namespace KodeOppgaveFraDag;

public class LongWordFinder
{
    private string LongWord;

    public LongWordFinder()
    {
        LongWord = "";
    }

    public void SetLongWord(string longWord)
    {
        LongWord += longWord;
    }

    public void FindLongestWord(string[] userScentence)
    {
        List<string> NewArray = userScentence.Select(s => new string(s.Where(char.IsLetter).ToArray())).ToList();

        foreach (var word in NewArray)
        {
            if (word.Length > LongWord.Length)
            {
                LongWord = word;
            }
        }
    }

    public string GetLongWord()
    {
        return LongWord;
    }
}