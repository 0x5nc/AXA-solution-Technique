using AXA_solution_Technique.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace ProducerConsumerTest
{
    [TestClass]
    public class UnitTest
    {
        //In a real scenario, TDD scenario specifically, these methods should have parameters to test the fields and inputs for our class
        //These serve as templates for future tests
        [TestMethod]
        public void Read_Works()
        {
            var mock = new Mock<IProducerConsumer>();
            mock.Verify(c=>c.ReadFile());
        }

        [TestMethod]
        public void Edit_Works()
        {
            var mock = new Mock<IProducerConsumer>();
            mock.Verify(c => c.EditFile());
        }

        [TestMethod]
        public void Print_Works()
        {
            var mock = new Mock<IProducerConsumer>();
            mock.Verify(c => c.PrintFile());
        }
    }
}
