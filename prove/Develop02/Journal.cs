public class Journal
{
    public string _journalname;

    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        foreach (Entry entry in _entries) {
            
            entry.Display();
        }
    }

}