using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class MathTests
    {
        // Existing Add tests...

        [Test]
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Program.Subtract("3", "2"));
            Assert.AreEqual(-4, Program.Subtract("3", "7"));
            Assert.AreEqual(0, Program.Subtract("5", "5"));
        }

        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(21, Program.Multiply("3", "7"));
            Assert.AreEqual(0, Program.Multiply("0", "5"));
        }

        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(1.5, Program.Divide("3", "2"));
            Assert.AreEqual(0.5, Program.Divide("3", "6"));
            Assert.Throws<System.DivideByZeroException>(() => Program.Divide("3", "0"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
            Assert.AreEqual(1, Program.Power("3", "0"));
            Assert.AreEqual(0, Program.Power("0", "5"));
        }

        [Test]
        public void Invalid_Input()
        {
            // Combined invalid input tests for all operations
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("b", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("1", "c"));
            Assert.Throws<FormatException>(() => Program.Power("d", "1"));
        }

        [Test]
        public void Null_Input()
        {
            // Combined null input tests for all operations
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
        }
    }
}
