using System;

public class MathAssingment : Assingment
{
    private string _textbookSection;
    private string _problems;

    public MathAssingment(string student, string topic, string section, string problems) : base(student, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} | Problems {_problems}";
    }
}