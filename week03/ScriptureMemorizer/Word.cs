using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

public class Word
{
    string _text;
    bool _isHidden;

    public Word (string text)
    {
        _text=text;
        _isHidden=false;
    }

    public void Hide()
    {
        char[] letters = _text.ToCharArray();
        for (int i = 0; i < letters.Length; i++)
        {
            letters[i] = '_';
        }
        _text = new string(letters);
        _isHidden = true;
    }
    
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}