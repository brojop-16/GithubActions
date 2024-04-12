using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using System;

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
        public void Subtract_Valid()
        {
            Assert.AreEqual(1, Math.Subtract("3", "2"));
            Assert.AreEqual(-1, Math.Subtract("1", "2"));
            Assert.AreEqual(2, Math.Subtract("5", "3"));
        }

        [Test]
        public void Subtract_Invalid()
        {
            Assert.Throws<FormatException>(() => Math.Subtract("1", "a"));
            Assert.Throws<FormatException>(() => Math.Subtract("a", "1"));
            Assert.Throws<FormatException>(() => Math.Subtract("a", "a"));
        }

        [Test]
        public void Subtract_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Math.Subtract("1", null));
            Assert.Throws<ArgumentNullException>(() => Math.Subtract(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Math.Subtract(null, null));
        }
        
        [Test]
        public void Multiply_Valid()
        {
            Assert.AreEqual(6, Math.Multiply("2", "3"));
            Assert.AreEqual(15, Math.Multiply("5", "3"));
            Assert.AreEqual(-12, Math.Multiply("-4", "3"));
        }

        [Test]
        public void Multiply_Invalid()
        {
            Assert.Throws<FormatException>(() => Math.Multiply("1", "a"));
            Assert.Throws<FormatException>(() => Math.Multiply("a", "1"));
            Assert.Throws<FormatException>(() => Math.Multiply("a", "a"));
        }

        [Test]
        public void Multiply_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Math.Multiply("1", null));
            Assert.Throws<ArgumentNullException>(() => Math.Multiply(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Math.Multiply(null, null));
        }
        
        [Test]
        public void Divide_Valid()
        {
            Assert.AreEqual(2, Math.Divide("6", "3"));
            Assert.AreEqual(5, Math.Divide("15", "3"));
            Assert.AreEqual(-4, Math.Divide("-12", "3"));
        }

        [Test]
        public void Divide_ByZero()
        {
            Assert.Throws<DivideByZeroException>(() => Math.Divide("1", "0"));
            Assert.Throws<DivideByZeroException>(() => Math.Divide("0", "0"));
        }

        [Test]
        public void Divide_Invalid()
        {
            Assert.Throws<FormatException>(() => Math.Divide("1", "a"));
            Assert.Throws<FormatException>(() => Math.Divide("a", "1"));
            Assert.Throws<FormatException>(() => Math.Divide("a", "a"));
        }

        [Test]
        public void Divide_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Math.Divide("1", null));
            Assert.Throws<ArgumentNullException>(() => Math.Divide(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Math.Divide(null, null));
        }
        
        [Test]
        public void Power_Valid()
        {
            Assert.AreEqual(8, Math.Power("2", "3"));
            Assert.AreEqual(9, Math.Power("3", "2"));
            Assert.AreEqual(1, Math.Power("5", "0"));
        }

        [Test]
        public void Power_Invalid()
        {
            Assert.Throws<FormatException>(() => Math.Power("1", "a"));
            Assert.Throws<FormatException>(() => Math.Power("a", "1"));
            Assert.Throws<FormatException>(() => Math.Power("a", "a"));
        }

        [Test]
        public void Power_Null()
        {
            Assert.Throws<ArgumentNullException>(() => Math.Power("1", null));
            Assert.Throws<ArgumentNullException>(() => Math.Power(null, "1"));
            Assert.Throws<ArgumentNullException>(() => Math.Power(null, null)); 
        }
    }
}
