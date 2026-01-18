using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename = "journal.txt")
    {
        using (StreamWriter outputJournal = new StreamWriter(filename))
        {
            foreach(Entry entry in _entries)
            {
                outputJournal.WriteLine($"{entry._date}~{entry._promptText}~{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename = "journal.txt")
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~");
            string date = parts[0];
            string prompt = parts[1];
            string text = parts[2];

            Entry entry = new Entry();
            entry._date = date;
            entry._promptText = prompt;
            entry._entryText = text;

            _entries.Add(entry);
        }
        
    }
}