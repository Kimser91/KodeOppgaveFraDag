namespace KodeOppgaveFraDag;

public class UserScentence
{
    private string TheScentence;

    public UserScentence()
    {
        TheScentence = "";
    }

    public string GetScentence()
    {
        return TheScentence;
    }

    public void SetScentence(string scentence)
    {
        if (scentence != "")
        {
            TheScentence = scentence;
        }
        else
        {
            TheScentence = "Den lille kattepus sov søtt på den gamle, slitte sofaen...";
        }
    }
}