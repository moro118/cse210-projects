public class Scripture
{
    Reference _reference;
    List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }

    // Improved: Only hides words that are not already hidden
    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = Math.Max(1, _words.Count / 5);
        int hiddenCount = 0;
        var unhiddenIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
                unhiddenIndexes.Add(i);
        }
        // If fewer unhidden words than wordsToHide, hide all remaining
        int toHide = Math.Min(wordsToHide, unhiddenIndexes.Count);
        while (hiddenCount < toHide)
        {
            int pick = random.Next(unhiddenIndexes.Count);
            int index = unhiddenIndexes[pick];
            _words[index].Hide();
            unhiddenIndexes.RemoveAt(pick);
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}