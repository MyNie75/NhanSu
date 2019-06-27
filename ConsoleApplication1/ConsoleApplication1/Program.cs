using System;
public class Song
{
    private string name;
    public Song NextItem { get; set; }

    public Song(string name)
    {
        this.name = name;
    }

    public bool IsRepeatList()
    {

        //Bạn viết code ở đây
        if (name == "Faded")
            return false;
        for (string i )

       

    }

    public static void Main(string[] args)
    {
        Song first = new Song("Faded");
        Song second = new Song("Spectre");

        first.NextItem = second;
        second.NextItem = first;

        Console.WriteLine(first.IsRepeatList());
    }
}