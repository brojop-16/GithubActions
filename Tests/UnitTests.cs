using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        // Add
        [Test]
        public void Add_Valid_Long()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid_Long()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null_Long()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        // Subtract
        [Test]
        public void Subtract_Valid_Long()
        {
            Assert.AreEqual(2, Program.Subtract("4", "2"));
            Assert.AreEqual(10, Program.Subtract("10", "0"));
            Assert.AreEqual(-2, Program.Subtract("3", "5"));
        }

        [Test]
        public void Subtract_Invalid_Long()
        {
            Assert.Throws<FormatException>(() => Program.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null_Long()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract(null, null));
        }

        // Multiply
        [Test]
        public void Multiply_Valid_Long()
        {
            Assert.AreEqual(6, Program.Multiply("3", "2"));
            Assert.AreEqual(0, Program.Multiply("10", "0"));
            Assert.AreEqual(-20, Program.Multiply("-4", "5"));
        }

        [Test]
        public void Multiply_Invalid_Long()
        {
            Assert.Throws<FormatException>(() => Program.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null_Long()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply(null, null));
        }

        // Divide
        [Test]
        public void Divide_Valid_Long()
        {
            Assert.AreEqual(4, Program.Divide("8", "2"));
            Assert.AreEqual(0, Program.Divide("0", "10"));
            Assert.AreEqual(-4, Program.Divide("-16", "4"));
        }

        [Test]
        public void Divide_Invalid_Long()
        {
            Assert.Throws<FormatException>(() => Program.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null_Long()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide(null, null));
        }

        // Power
        [Test]
        public void Power_Valid_Long()
        {
            Assert.AreEqual(27, Program.Power("3", "3"));
            Assert.AreEqual(1, Program.Power("8", "0"));
            Assert.AreEqual(16, Program.Power("2", "4"));
        }

        [Test]
        public void Power_Invalid_Long()
        {
            Assert.Throws<FormatException>(() => Program.Power("1", "a"));
            Assert.Throws<FormatException>(() => Program.Power("a", "1"));
            Assert.Throws<FormatException>(() => Program.Power("a", "a"));
        }

        [Test]
        public void Power_Null_Long()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Power(null, null));
        }
    }
}
