public class Scripture
{
    private Reference _reference;
    private Word[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = GetWords(text);
    }

    private Word[] GetWords(string text)
    {
        string[] wordStrings = text.Split(' ');
        Word[] words = new Word[wordStrings.Length];

        for (int i = 0; i < wordStrings.Length; i++)
        {
            words[i] = new Word(wordStrings[i]);
        }

        return words;
    }

 public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(0, _words.Length);
        _words[index].Hide();
    }

    public override string ToString()
    {
        string result = _reference.ToString() + "\n";
        foreach (Word word in _words)
        {
            result += word.ToString() + " ";
        }
        return result;
    }
    public bool AreAllWordsHidden()
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
