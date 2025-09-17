public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

    }
    public void SaveToFile(string file)
    {
            
         StreamWriter   outputFile = new StreamWriter(file);
       
        foreach (Entry entry in _entries)
            {

                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
           
            }
        outputFile.Close();
    }
    public void LoadFromFile(string file)
    {   try
        {
            StreamReader inputFile = new StreamReader(file);

            string line;
            while (!inputFile.EndOfStream)
            {
                line = inputFile.ReadLine();
                string[] parts = line.Split("|");
                Entry entry = new Entry();
                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
            inputFile.Close();
         }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }
    }
}