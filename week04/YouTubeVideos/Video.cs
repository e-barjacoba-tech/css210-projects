using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList = new List<Comment>();

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

    //I added the CommentaryCount method
    public int CommentaryCount()
    {
        return _commentList.Count();
    }
    public string DisplayDetails()
    {
        string details = $"{_title}: by {_author} ({_length} seconds long)\n";
        details += $"It has {CommentaryCount()} comments\n";
        foreach (Comment comment in _commentList)
        {
            details += $"{comment.DisplayComment()}\n";
        }

        return details;
    }
}