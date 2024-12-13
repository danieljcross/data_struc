using System;
using System.Collections.Generic;

public class CustomersQueue
{
    private Queue<string> queue = new Queue<string>();

    // Add a song to the back of the queue
    public void NewOrder(string person){
        queue.Enqueue(person);
        // Console.WriteLine($"New customer added: {person}"); // This can be uncommented for testing
    }

    // Play and remove the song from the front of the queue
    public string ServeOrder(){
        if (queue.Count > 0){
            string person = queue.Dequeue();
            Console.WriteLine($"Now serving: {person}");
            return person;
        }
        else{
            Console.WriteLine("No customers.");
            return null;
        }
    }
}
