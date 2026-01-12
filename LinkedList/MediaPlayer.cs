//Scenario 2: Music Playlist Queue
//Use Case: A music player plays songs one after another and can dynamically add/remove
//songs.
//Why LinkedList? Dynamic addition/removal from both ends.
//OOP Concepts:
//● Encapsulation: Playlist data is secured.
//● Abstraction: Methods like playNext(), addSong() simplify usage.
//● Polymorphism: If we extend MediaPlayer, it could play videos, podcasts, etc.

using System;

class Song 
{
    public string song;
    public Song next;

    public Song(string song)
    {
        this.song = song;
        this.next = null;
    }
}

abstract class MediaPlayer
{
    protected Song head;
    protected Song tail;

    public abstract void PlayNext();

    public void AddSong(string song)
    {
        Song newSong = new Song(song);

        if(head == null)
        {
            head = tail = newSong;
        }
        else
        {
            tail.next = newSong;
            tail = newSong;
        }

        Console.WriteLine($"new song added {tail.song}");
    }

    public void CurrentSong()
    {
        Console.WriteLine($"current songs is:{tail.song}");
    }
}

class MusicPlayer : MediaPlayer
{
    public override void PlayNext()
    {
        if (head == null && head.next == null)
        {
            Console.WriteLine("their is no next song");
            return;
        }
        else
        {
            head = head.next;
            Console.WriteLine("Now playing: " + head.song);
        }
    }
}