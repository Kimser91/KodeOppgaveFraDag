namespace KodeOppgaveFraDag;

public class ShortWordFinder
{
    private string ShortWord;

    public ShortWordFinder()
    {
        ShortWord = "";
    }

    public void SetShortWord(string shortWord)
    {
        ShortWord = shortWord;
    }

    public void FindShortestWord(string[] userScentence)
    {
        List<string> NewArray = userScentence.Select(s => new string(s.Where(char.IsLetter).ToArray())).ToList();

        foreach (var word in NewArray)
        {

            if (ShortWord == "" || word.Length < ShortWord.Length)
            {

                ShortWord = word;
            }
        }
    }

    public string GetShortWord()
    {
        return ShortWord;
    }
}