using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Word
{

    public string _text;
    public bool _isHidden;
    

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void Hide()
    {
        _isHidden = true;
    }

    // public override string Show()
    // {
    //     _isHidden ? new string('_', _text.Length) : _text;
    // } 

    public bool IsHidden()
    {
        return false;
    }

    public string GetDisplayText()
    {
       return "";
    }
}