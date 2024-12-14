using System;
using System.Collections.Generic;

class WeddingInviteTests{
    public static void RunTests(){
        TestUniqueInviteList();
    }

    private static void TestUniqueInviteList(){
        // Test case
        // Scenario: Two lists each have a name in common. We want a list of all unique names.
        // Expected output: Jessica, Dave, Vincent, Drew, Hannah, Emily, Ezra (order may vary)
        Console.WriteLine("Test 1");
        List<string> danielsList = new List<string> { "Jessica", "Dave", "Vincent", "Drew" };
        List<string> emmasList = new List<string> { "Hannah", "Vincent", "Emily", "Ezra" };

        HashSet<string> uniqueInviteList = WeddingInvite.CreateUniqueInviteList(danielsList, emmasList);

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
