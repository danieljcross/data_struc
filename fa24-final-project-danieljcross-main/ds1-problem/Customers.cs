using System;

public class Customers
{
    public static void RunTests()
    {

        // Test 1
        // Scenario: Add Bob's order, then Jack's order, then Jill's order. Serve the first two. 
        // Expected Result: Serve Bob, then Jack.

        Console.WriteLine("Test 1");


        // Test 2
        // Scenario: Take Bob's order and Jack's order, then serve an order. Take Jill's order, then 
        // serve 2 more orders.
        // Expected Result: Serve Bob, then Jack, then Jill.

        Console.WriteLine("\nTest 2");


        // Test 3
        // Scenario: Try to serve a non-existing order.
        // Expected Result: "No customers" error should appear.

        Console.WriteLine("\nTest 3");


    }
}
