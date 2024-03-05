using System;

public static class Priority
{
    public static void Test()
    {
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Summary:  Before fixing the code, the dequeue operation was not removing
        // items with the highest priority, and the error handling for an empty queue
        // was not functioning correctly.

        // Test Cases

        // Test 1
        // Scenario: Enqueue two items with different priorities, dequeue one item.
        // Expected Result: The item with the highest priority should be dequeued.
        Console.WriteLine("Test 1");
        var priorityQueue1 = new PriorityQueue(); // Create a new instance for each test
        priorityQueue1.Enqueue("Item 1", 2);
        priorityQueue1.Enqueue("Item 2", 1);
        Console.WriteLine(priorityQueue1);
        Console.WriteLine("Dequeued item: " + priorityQueue1.Dequeue());
        Console.WriteLine(priorityQueue1);
        Console.WriteLine("---------");
        // Summary: Only the item with the lowest priority was dequeued.

        // Test 2
        // Scenario: Enqueue three items with the same highest priority, dequeue one item.
        // Expected Result: The item added first among those with the highest priority should be dequeued.
        Console.WriteLine("Test 2");
        var priorityQueue2 = new PriorityQueue(); // Create a new instance for each test
        priorityQueue2.Enqueue("Item 3", 3);
        priorityQueue2.Enqueue("Item 4", 3);
        priorityQueue2.Enqueue("Item 5", 3);
        Console.WriteLine(priorityQueue2);
        Console.WriteLine("Dequeued item: " + priorityQueue2.Dequeue());
        Console.WriteLine(priorityQueue2);
        Console.WriteLine("---------");
        // Summary: Only the item with the lowest priority was dequeued.

        // Test 3
        // Scenario: Dequeue an item from an empty queue.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 3");
        var priorityQueue3 = new PriorityQueue(); // Create a new instance for each test
        Console.WriteLine("Dequeued item: " + priorityQueue3.Dequeue()); // Attempt to dequeue from an empty queue
        Console.WriteLine("---------");
        // Summary: Unexpectedly dequeued an item from an empty queue without displaying the error message.
    }
}
