using System;

public class Customers
{
    public static void RunTests()
    {

        // Test 1
        // Scenario: Add Bob's order, then Jack's order, then Jill's order. Serve the first two. 
        // Expected Result: Serve Bob, then Jack.

        Console.WriteLine("Test 1");
        CustomersQueue customersQueue1 = new CustomersQueue();
        customersQueue1.NewOrder("Bob");
        customersQueue1.NewOrder("Jack");
        customersQueue1.NewOrder("Jill");

        customersQueue1.ServeOrder();  // Serves Bob's food
        customersQueue1.ServeOrder();  // Serves Jack's food

        // Test 2
        // Scenario: Take Bob's order and Jack's order, then serve an order. Take Jill's order, then 
        // serve 2 more orders.
        // Expected Result: Serve Bob, then Jack, then Jill.

        Console.WriteLine("\nTest 2");
        CustomersQueue customersQueue2 = new CustomersQueue();
        customersQueue2.NewOrder("Bob");
        customersQueue2.NewOrder("Jack");
        customersQueue2.ServeOrder();  // Serves Bob's food
        customersQueue2.NewOrder("Jill");
        customersQueue2.ServeOrder();  // Serves Jack's food
        customersQueue2.ServeOrder();  // Serves Jill's food

        // Test 3
        // Scenario: Try to serve a non-existing order.
        // Expected Result: "No customers" error should appear.

        Console.WriteLine("\nTest 3");
        CustomersQueue customersQueue3 = new CustomersQueue();
        customersQueue3.ServeOrder();  // Should print "No customers."
    }
}
