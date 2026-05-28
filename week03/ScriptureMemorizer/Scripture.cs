using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words.AddRange(text.Split(" ").Select(word => new Word(word))); 
        // It takes all the words and put them into an array
        // AddRange transforms that into a list
        // Split takes the empty spaces and uses that as a separator for all the words
        // The syntax "Select(word => new Word(word)))" iterates through all the words and turns them into an object
        // That way, the _words list stores different Word instances 
    }

    public void HideRandomWords (int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        return ;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
