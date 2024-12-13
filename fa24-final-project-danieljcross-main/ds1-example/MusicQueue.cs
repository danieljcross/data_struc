using System;
using System.Collections.Generic;

public class MusicQueue
{
    private Queue<string> queue = new Queue<string>();

    // Add a song to the back of the queue
    public void AddSong(string song){
        queue.Enqueue(song);
        // Console.WriteLine($"Song added: {song}"); // This can be commented out for testing
    }

    // Play and remove the song from the front of the queue
    public string PlaySong(){
        if (queue.Count > 0){
            string song = queue.Dequeue();
            Console.WriteLine($"Playing song: {song}");
            return song;
        }
        else{
            Console.WriteLine("No songs left to play.");
            return null;
        }
    }
}
