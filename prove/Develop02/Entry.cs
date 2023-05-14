using System;
using System.Collections.Generic;

public class Entry 
{
    public string _textEntry;
    public string _dateEntry;
    public string _prompt;

    public void Display()
    {
        Console.WriteLine ($"{_dateEntry}\n{_prompt}\n{_textEntry}\n ");
    }
}