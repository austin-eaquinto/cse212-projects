using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the back of the queue.
    // Expected Result: Add and item to the queue in the correct order of FIFO
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("tim", 1);
        priorityQueue.Enqueue("bill", 3);
        priorityQueue.Enqueue("rob", 2);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: The item with the highest priority is removed first
    // Defect(s) Found: none
    public void TestPriorityQueue_2()
    {
        
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("tim", 1);
        priorityQueue.Enqueue("bill", 3);
        priorityQueue.Enqueue("rob", 2);

        var person = priorityQueue.Dequeue();

        Assert.AreEqual(person, "bill");

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front of the 
                // queue will be removed and its value returned.
    // Expected Result: If two items have the same priority, the one that was first in will be first out
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("tim", 1);
        priorityQueue.Enqueue("bill", 3);
        priorityQueue.Enqueue("rob", 2);
        priorityQueue.Enqueue("daniel", 3);

        var person = priorityQueue.Dequeue();

        Assert.AreEqual(person, "bill");

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: return an error message if the queue is empty
    // Defect(s) Found: none
    public void TestPriorityQueue_4()
    {
        try
        {
            var priorityQueue = new PriorityQueue();
            priorityQueue.Enqueue("tim", 1);
            priorityQueue.Enqueue("bill", 3);
            priorityQueue.Enqueue("rob", 2);
            priorityQueue.Enqueue("daniel", 3);

            var person = priorityQueue.Dequeue();
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("The queue is empty");
        }

        // Assert.Fail("Implement the test case and then remove this.");
    }
}
