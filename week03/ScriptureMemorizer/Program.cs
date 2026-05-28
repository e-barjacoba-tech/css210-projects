using System;

class Program
{
    static void Main(string[] args)
    {
        Reference john = new Reference("John", 3, 5);
        Scripture s1 = new Scripture(john,"Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.");
    }
}