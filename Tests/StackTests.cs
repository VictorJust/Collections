using Collections.Collections;
using NUnit.Framework;

namespace Tests
{
    public class StackTests
    {
        private ListBasedStack<int> stack;

        [SetUp]
        public void Setup()
        {
            stack = new ListBasedStack<int>(new List<int> { 0, 1, 2, 3, 4 });
        }

        [Test]
        public void Push_AddsElementToStack()
        {
            // Arrange
            var value = 5;

            // Act
            stack.Push(value);

            // Assert
            Assert.That(stack.Pop(), Is.EqualTo(value));
        }

        [Test]
        public void Pop_RemovesAndReturnsTopElement()
        {
            // Arrange
            var expected = 4;

            // Act
            var result = stack.Pop();

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void Pop_OnEmptyStack_ThrowsException()
        {
            // Arrange
            stack = new ListBasedStack<int>(new List<int>());

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }
    }
}
