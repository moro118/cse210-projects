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
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                
                string date = EscapeCsv(entry._date);
                string prompt = EscapeCsv(entry._promptText);
                string text = EscapeCsv(entry._entryText);
                string mood = EscapeCsv(entry._mood);
                outputFile.WriteLine($"{date},{prompt},{text},{mood}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        try
        {
            using (StreamReader inputFile = new StreamReader(file))
            {
                string line;
                while ((line = inputFile.ReadLine()) != null)
                {
                    string[] parts = ParseCsvLine(line);
                    if (parts.Length >= 4)
                    {
                        Entry entry = new Entry();
                        entry._date = parts[0];
                        entry._promptText = parts[1];
                        entry._entryText = parts[2];
                        entry._mood = parts[3];
                        _entries.Add(entry);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading file: {ex.Message}");
        }
    }
   
    private string EscapeCsv(string value)
    {
        if (value.Contains("\"") || value.Contains(","))
        {
            value = value.Replace("\"", "\"\"");
            value = $"\"{value}\"";
        }
        return value;
    }

    private string[] ParseCsvLine(string line)
    {
        var result = new List<string>();
        bool inQuotes = false;
        string current = "";
        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (c == '"')
            {
                if (inQuotes && i + 1 < line.Length && line[i + 1] == '"')
                {
                    current += '"';
                    i++;
                }
                else
                {
                    inQuotes = !inQuotes;
                }
            }
            else if (c == ',' && !inQuotes)
            {
                result.Add(current);
                current = "";
            }
            else
            {
                current += c;
            }
        }
        result.Add(current);
        return result.ToArray();
    }
}