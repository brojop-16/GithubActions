using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid_Hoyt()
        {
            Assert.AreEqual(3, Program.Add_Hoyt("1", "2"));
            Assert.AreEqual(5, Program.Add_Hoyt("3", "2"));
            Assert.AreEqual(12, Program.Add_Hoyt("5", "7"));
        }

        [Test]
        public void Add_Invalid_Hoyt()
        {
            Assert.Throws<FormatException>(() => Program.Add_Hoyt("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add_Hoyt("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add_Hoyt("a", "a"));
        }

        [Test]
        public void Add_Null_Hoyt()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add_Hoyt("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add_Hoyt(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add_Hoyt(null, null));
        }

        // Implement 3 tests per operation, following a similar pattern as above
        [Test]
        public void Subtract_Valid_Hoyt()
        {
            Assert.AreEqual(-1, Program.Subtract_Hoyt("1", "2"));
            Assert.AreEqual(1, Program.Subtract_Hoyt("3", "2"));
            Assert.AreEqual(-2, Program.Subtract_Hoyt("5", "7"));
        }

        [Test]
        public void Subtract_Invalid_Hoyt()
        {
            Assert.Throws<FormatException>(() => Program.Subtract_Hoyt("1", "a"));
            Assert.Throws<FormatException>(() => Program.Subtract_Hoyt("a", "1"));
            Assert.Throws<FormatException>(() => Program.Subtract_Hoyt("a", "a"));
        }

        [Test]
        public void Subtract_Null_Hoyt()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Subtract_Hoyt("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract_Hoyt(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Subtract_Hoyt(null, null));
        }

        [Test]
        public void Multiply_Valid_Hoyt()
        {
            Assert.AreEqual(2, Program.Multiply_Hoyt("1", "2"));
            Assert.AreEqual(6, Program.Multiply_Hoyt("3", "2"));
            Assert.AreEqual(35, Program.Multiply_Hoyt("5", "7"));
        }

        [Test]
        public void Multiply_Invalid_Hoyt()
        {
            Assert.Throws<FormatException>(() => Program.Multiply_Hoyt("1", "a"));
            Assert.Throws<FormatException>(() => Program.Multiply_Hoyt("a", "1"));
            Assert.Throws<FormatException>(() => Program.Multiply_Hoyt("a", "a"));
        }

        [Test]
        public void Multiply_Null_Hoyt()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Multiply_Hoyt("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply_Hoyt(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Multiply_Hoyt(null, null));
        }

        [Test]
        public void Divide_Valid_Hoyt()
        {
            Assert.AreEqual(0.5, Program.Divide_Hoyt("1", "2"));
            Assert.AreEqual(1.5, Program.Divide_Hoyt("3", "2"));
            Assert.AreEqual(3, Program.Divide_Hoyt("6", "2"));
        }

        [Test]
        public void Divide_Invalid_Hoyt()
        {
            Assert.Throws<FormatException>(() => Program.Divide_Hoyt("1", "a"));
            Assert.Throws<FormatException>(() => Program.Divide_Hoyt("a", "1"));
            Assert.Throws<FormatException>(() => Program.Divide_Hoyt("a", "a"));
        }

        [Test]
        public void Divide_Null_Hoyt()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Divide_Hoyt("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Divide_Hoyt(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Divide_Hoyt(null, null));
        }
    }
}
