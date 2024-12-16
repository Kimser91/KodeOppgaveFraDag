using KodeOppgaveFraDag;

CharCounter counter = new CharCounter();
WordCounter wordCounter = new WordCounter();
LongWordFinder longestWord = new LongWordFinder();
ShortWordFinder shortesWord = new ShortWordFinder();
UserScentence newSentence = new UserScentence();

string userSentence;
string[] stringList;

StartMenu();

void StartMenu()
{
    Console.WriteLine("welcome to the word app");
    Console.WriteLine("write your sentence:");
    userSentence = Console.ReadLine();
    newSentence.SetScentence(userSentence);
    stringList = newSentence.GetScentence().Split(' ');
    MainMenu();
}

void MainMenu()
{


    while (true)
    {
        Console.WriteLine("1. Char counter");
        Console.WriteLine("2. Word Counter");
        Console.WriteLine("3. Find the longest Word");
        Console.WriteLine("4. shortestWord");
        Console.WriteLine("Q. Exit");
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine(counter.CountChars(newSentence.GetScentence()));
                break;
            case "2":
                Console.WriteLine(wordCounter.countWords(stringList));
                break;
            case "3":
                longestWord.FindLongestWord(stringList);
                Console.WriteLine(longestWord.GetLongWord());
                break;
            case "4":
                shortesWord.FindShortestWord(stringList);
                Console.WriteLine(shortesWord.GetShortWord());
                break;
            case "5":
                StartMenu();
                break;
            default:
                Environment.Exit(0);
                break;

        }
    }
}