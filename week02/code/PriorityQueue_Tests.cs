using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: The Enqueue function shall add an item (which contains both data and priority) to the 
    // back of the queue.
    // Expected Result: adds a person and priority identifier to the queue
    // Defect(s) Found: none
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alan", 2);
        priorityQueue.Enqueue("Bill", 1);

        // Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: The Dequeue function shall remove the item with the highest priority and return its value.
    // Expected Result: Dequeue Carl first, even though he's last in the queue because he has the highest priority
    // Defect(s) Found: Carl isn't reached at all in the program. ToString prints whole queue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alan", 2);
        priorityQueue.Enqueue("Bill", 3);
        priorityQueue.Enqueue("Carl", 1);
        
        priorityQueue.Dequeue();
        // priorityQueue.Dequeue();

        priorityQueue.ToString();

        // Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: If there are more than one item with the highest priority, then the item closest to the front 
    // of the queue will be removed and its value returned.
    // Expected Result: Alan will be removed before Bill because they have the same priority but Alan is first in line.
    // Defect(s) Found: Keep getting result "Bill". 
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Alan", 3);
        priorityQueue.Enqueue("Bill", 3);
        priorityQueue.Enqueue("Carl", 1);

        priorityQueue.Dequeue();
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // Expected Result: the code will throw and exception for the empty queue
    // Defect(s) Found: none
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
    }
}