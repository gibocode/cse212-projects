using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add an item which contains both data and priority to the back of the queue.
    // Expected Result: Red, Yellow, Blue, Green, Purple
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_Enqueue()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Red", 3);
        priorityQueue.Enqueue("Yellow", 4);
        priorityQueue.Enqueue("Blue", 2);
        priorityQueue.Enqueue("Green", 5);
        priorityQueue.Enqueue("Purple", 1);

        Assert.AreEqual("[Red (Pri:3), Yellow (Pri:4), Blue (Pri:2), Green (Pri:5), Purple (Pri:1)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Remove an item from the queue based on highest priority and return its value.
    // Expected Result: Red, Blue, Purple
    // Defect(s) Found: Queue item not removed when dequeued.
    public void TestPriorityQueue_Dequeue()
    {
        var priorityQueue = new PriorityQueue();

        // Adds priority items first
        priorityQueue.Enqueue("Red", 3);
        priorityQueue.Enqueue("Yellow", 4);
        priorityQueue.Enqueue("Blue", 2);
        priorityQueue.Enqueue("Green", 5);
        priorityQueue.Enqueue("Purple", 1);

        // Dequeue items and verify the order
        Assert.AreEqual("Green", priorityQueue.Dequeue());
        Assert.AreEqual("Yellow", priorityQueue.Dequeue());

        Assert.AreEqual("[Red (Pri:3), Blue (Pri:2), Purple (Pri:1)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Remove an item from the queue with the same priority return its value.
    // Expected Result: Red, Blue, Purple
    // Defect(s) Found: Last item was removed instead of the first item in the queeue with the same priority.
    public void TestPriorityQueue_DequeueSamePriority()
    {
        var priorityQueue = new PriorityQueue();

        // Adds priority items first
        priorityQueue.Enqueue("Red", 3);
        priorityQueue.Enqueue("Yellow", 4);
        priorityQueue.Enqueue("Blue", 2);
        priorityQueue.Enqueue("Green", 4);
        priorityQueue.Enqueue("Purple", 1);

        Console.WriteLine(priorityQueue.ToString());

        // Dequeue item
        Assert.AreEqual("Yellow", priorityQueue.Dequeue());

        Assert.AreEqual("[Red (Pri:3), Blue (Pri:2), Green (Pri:4), Purple (Pri:1)]", priorityQueue.ToString());
    }

    [TestMethod]
    // Scenario: Remove an item from the an empty queue.
    // Expected Result: Throw an InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: No defects found.
    public void TestPriorityQueue_DequeueEmpty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}
