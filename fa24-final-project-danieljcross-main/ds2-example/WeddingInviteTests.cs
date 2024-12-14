using System;
using System.Collections.Generic;

class WeddingInviteTests{
    public static void RunTests(){
        TestUniqueInviteList();
    }

    private static void TestUniqueInviteList(){

        // Test case 1
        // Scenario: Two lists each have a name in common. We want a list of all unique names.
        // Expected output: Jessica, Dave, Vincent, Drew, Hannah, Emily, Ezra (order may vary)
        Console.WriteLine("Test 1");
        
        // Create the two lists
        List<string> danielsList = new List<string> { "Jessica", "Dave", "Vincent", "Drew" };
        List<string> emmasList = new List<string> { "Hannah", "Vincent", "Emily", "Ezra" };

        // Get a list of just the unique names
        HashSet<string> uniqueInviteList = WeddingInvite.CreateUniqueInviteList(danielsList, emmasList);

        // Print all of the unique names
        int listCount = uniqueInviteList.Count;
        foreach (string name in uniqueInviteList){
            Console.Write(name);
            listCount -= 1;
            if (listCount > 1){
                Console.Write(", ");
            }
            else if (listCount == 1){
                Console.Write(", and ");
            }
        }
    }
}
