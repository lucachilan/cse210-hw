using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private Reference _reference;
    List<Word> _words = new List<Word>();
    int _hiddenWords;
    public Scripture (Reference Reference, string text)
    {
        _reference = Reference;
        string[] words = text.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            Word scriptureWord = new Word(words[i]);
            _words.Add(scriptureWord);
        }
    }
    public static Scripture GetRandomScripture()
    {
        ScriptureProvider provider = new ScriptureProvider();
        return provider.GetRandomScripture();
    }
    public void HideRandomWords(int numberToHide)
    {       
        Random random = new Random();
        if (_words.Count()-_hiddenWords < numberToHide)
        {
            numberToHide = _words.Count()-_hiddenWords;
        }
        int randomIndex;
        if (!IsCompletelyHidden())
        { 
            for (int i=0; i<numberToHide;i++)
            {
                randomIndex = random.Next(_words.Count());
                Word wordToHide = _words[randomIndex];
                if (wordToHide.IsHidden() == false)
                {
                    wordToHide.Hide();
                    _hiddenWords+=1;
                }
                else
                {
                    i--;
                }
            }
        }   
    }
    public Reference GetReference()
    {
        return _reference;
    }
    public string GetDisplayText()
    {
        string displayText=_reference.GetDisplayText();
        foreach(Word word in _words)
        {
            displayText = displayText + " " + word.GetDisplayText() ;
        }
        return displayText;
    }
    public bool IsCompletelyHidden()
    {
        if(_hiddenWords == _words.Count())
        {
            return true;
        }
        return false;
    }
}