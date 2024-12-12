namespace prove_04;

/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The Enqueue function shall add an item (which contains both data and priority) to 
        // the back of the queue. The Dequeue function shall remove the item with the highest priority 
        // and return its value.

        // Expected Result: Ryan, Brent, Adam

        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);
        priorityQueue.Enqueue("Ryan", 1);
        priorityQueue.Enqueue("Brent", 2);
        priorityQueue.Enqueue("Adam", 3);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: If there are more than one item with the highest priority, then the item closest to 
        // the front of the queue will be removed and its value returned.
        // Expected Result: Brent, Adam, Nathan
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue();
        Console.WriteLine(priorityQueue);
        priorityQueue2.Enqueue("Brent", 2);
        priorityQueue2.Enqueue("Ryan", 1);
        priorityQueue2.Enqueue("Adam", 2);
        priorityQueue2.Enqueue("Daniel", 3);
        // Console.WriteLine(players);    // This can be un-commented out for debug help

        // I have not yet solved this portion, but this is a general idea of what I was about to do.
        //
        // foreach (person in priorityQueue2)
        //     priorityQueue2.GetNextPerson();

        // Defect(s) Found: Unresolved. 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: If the queue is empty, then an error message will be displayed.
        // Expected Result: Brent, Adam, Nathan

        var priorityQueue3 = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        Console.WriteLine("Test 3");
        
        
    }
}