using System;
using NUnit.Framework;

namespace GithubActionsLab
{
    [TestFixture]
    public class Math
    {
        [Test]
        public void Add_Valid()
        {
            Assert.AreEqual(3, Program.Add("1", "2"));
            Assert.AreEqual(5, Program.Add("3", "2"));
            Assert.AreEqual(12, Program.Add("5", "7"));
        }

        [Test]
        public void Add_Invalid()
        {
            Assert.Throws<FormatException>(() => Program.Add("1", "a"));
            Assert.Throws<FormatException>(() => Program.Add("a", "1"));
            Assert.Throws<FormatException>(() => Program.Add("a", "a"));
        }

        [Test]
        public void Add_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Program.Add("1", null));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Program.Add(null, null));
        }

        [Test]
        public void Subtract_Valid_Gurney()
        {
            Assert.AreEqual(1, Program.Subtract("2", "2"));
            Assert.AreEqual(-1, Program.Subtract("1", "2"));
            Assert.AreEqual(10, Program.Subtract("15", "5"));
        }

        [Test]
        public void Multiply_Valid_Gurney()
        {
            Assert.AreEqual(4, Program.Multiply("2", "2"));
            Assert.AreEqual(0, Program.Multiply("0", "5"));
            Assert.AreEqual(-10, Program.Multiply("2", "-5"));
        }

        [Test]
        public void Divide_Valid_Gurney()
        {
            Assert.AreEqual(1, Program.Divide("2", "2"));
            Assert.AreEqual(2, Program.Divide("10", "5"));
            Assert.Throws<DivideByZeroException>(() => Program.Divide("5", "0"));
        }

        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(9, Program.Power("3", "2"));
        }

    }
}
