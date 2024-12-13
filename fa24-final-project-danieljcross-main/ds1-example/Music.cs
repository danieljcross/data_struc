using System;

public class Music
{
    public static void RunTests()
    {

        // Test 1
        // Scenario: Add Song A, Song B, then Song C. Play two songs.
        // Expected Result: Song A, Song B

        Console.WriteLine("Test 1");
        MusicQueue musicQueue1 = new MusicQueue();
        musicQueue1.AddSong("Song A");
        musicQueue1.AddSong("Song B");
        musicQueue1.AddSong("Song C");

        musicQueue1.PlaySong();  // Plays Song A
        musicQueue1.PlaySong();  // Plays Song B

        // Test 2
        // Scenario: Add Song A and Song B, then play a song. Add Song C, then play two songs. 
        // Expected Result: Song A, Song B, Song C

        Console.WriteLine("\nTest 2");
        MusicQueue musicQueue2 = new MusicQueue();
        musicQueue2.AddSong("Song A");
        musicQueue2.AddSong("Song B");
        musicQueue2.PlaySong();  // Plays Song A
        musicQueue2.AddSong("Song C");
        musicQueue2.PlaySong();  // Plays Song B
        musicQueue2.PlaySong();  // Plays Song C

        // Test 3
        // Scenario: Try to play a song from an empty list.
        // Expected Result: "No songs left to play" error should appear.

        Console.WriteLine("\nTest 3");
        MusicQueue musicQueue3 = new MusicQueue();
        musicQueue3.PlaySong();  // Should print "No songs left to play."
    }
}
