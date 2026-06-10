using System;

public class Assingment
{
    //I used "protected" because I don't like ussing getters and setters
    protected string _studentName;
    private string _topic;

    public Assingment(string student, string topic)
    {
        _studentName = student;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}