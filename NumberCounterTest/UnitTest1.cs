using System;
using NumberCounter;

namespace NumberCounterTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1() 
        {
            MySingleton singleton = MySingleton.GetInstance();
            singleton.Increment();
            singleton.Increment();
            Assert.Equal(2, singleton.getActualCountNumber());  
        }

        [Fact]
        public void TestDecrement()
        {
            MySingleton singleton = MySingleton.GetInstance();
            singleton.Decrement();
            singleton.Decrement();
            Assert.Equal(-2, singleton.getActualCountNumber()); // Change to return count from GetCounterNumber()
        }
        [Fact]
        public void TestDoSomething()
        {
            MySingleton singleton = MySingleton.GetInstance();
            string expectedMessage = "Test Message";
            singleton.DoSomething(expectedMessage);
        }

        [Theory]
        [InlineData(-2)]
        [InlineData(-5)]
        [InlineData(-12)]
        public void TestDecrementInline(int expectedCount)
        {
            MySingleton singleton = MySingleton.GetInstance();
            singleton.Decrement();
            singleton.Decrement();
            Assert.Equal(expectedCount, singleton.getActualCountNumber());
        }
    }
}