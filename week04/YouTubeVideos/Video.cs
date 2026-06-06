using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    public Video (string title, string author, int lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
    }

    public void AddComment(Comment comment)
    {
        _commentList.Add(comment);
    }

    public string DisplayDetails()
    {
        return "";
    }
}