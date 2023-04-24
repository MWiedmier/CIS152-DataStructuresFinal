using System;
using System.Linq;
using Xunit;

namespace CIS152DataStructuresFinalWiedmierUnitTests
{
    public class PriorityQueueTests
    {
        [Fact]
        public void TestMethod1()
        {
        }

        //  FOR THE QUEUE MAKE IT WORK FOR PQUEUES 

        //[Fact]
        //public void TestCreatequeue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    bool actual;
        //    // ACT
        //    actual = myQueue.isEmpty();
        //    // ASSERT
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsEmptyTrue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    bool actual;
        //    // ACT
        //    actual = myQueue.isEmpty();
        //    // ASSERT
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsEmptyFalse()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "C# is Fun!";
        //    bool actual;
        //    // ACT
        //    myQueue.enqueue(item);
        //    actual = myQueue.isEmpty();
        //    // ASSERT
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void TestEnqueue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "queueItem";
        //    String actual, expected;
        //    expected = "queueItem1";
        //    // ACT
        //    myQueue.enqueue(item + "1");
        //    myQueue.enqueue(item + "2");
        //    actual = myQueue.peek();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void TestDequeue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "queueItem";
        //    String actual, expected;
        //    expected = item;
        //    myQueue.enqueue(item);
        //    // ACT
        //    actual = myQueue.dequeue();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void TestSizeZero()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    int actual, expected;
        //    expected = 0;
        //    // ACT
        //    actual = myQueue.size();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void TestSizeNonZero()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "queueItem";
        //    int actual, expected;
        //    expected = 2;
        //    // ACT
        //    myQueue.enqueue(item + "1");
        //    myQueue.enqueue(item + "2");
        //    actual = myQueue.size();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void TestDequeueEmptyQueue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    // ACT
        //    // ASSERT
        //    Assert.Throws<QueueLab.queueEmptyException>(() => myQueue.dequeue());
        //}

        //[Fact]
        //public void TestPeek()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "queueItem";
        //    String actual, expected;
        //    expected = item;
        //    // ACT
        //    myQueue.enqueue(item);
        //    actual = myQueue.peek();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}

        //[Fact]
        //public void TestPeekEmptyQueue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    // ACT
        //    // ASSERT
        //    Assert.Throws<QueueLab.queueEmptyException>(() => myQueue.peek());
        //}

        //[Fact]
        //public void TestPrintQueueEmptyQueue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    // ACT
        //    // ASSERT
        //    Assert.Throws<QueueLab.queueEmptyException>(() => myQueue.printQueue());
        //}
        //[Fact]
        //public void TestPrintQueue()
        //{
        //    // ARRANGE
        //    QueueLab.queue myQueue = new QueueLab.queue();
        //    String item = "queueItem";
        //    String actual, expected;
        //    expected = "queueItem1\nqueueItem2\n";
        //    // ACT
        //    myQueue.enqueue(item + "1");
        //    myQueue.enqueue(item + "2");
        //    actual = myQueue.printQueue();
        //    // ASSERT
        //    Assert.Equal(expected, actual);
        //}
    }
}
