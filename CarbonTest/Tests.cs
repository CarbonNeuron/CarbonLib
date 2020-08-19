using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using NUnit.Framework;
using static CarbonLib.Helpers;

namespace CarbonTest
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestRandom()
        {
            var TestList = new List<int> {1,2,3,4,5,6,7,8,9,10};
            var random = TestList.SelectRandom();
            Assert.NotNull(random);
        }
        [Test]
        public void TestListToString()
        {
            var TestList = new List<int> {1,2,3,4,5,6,7,8,9,10};
            var returnedString = TestList.MergeListUsingComma();
            var expected = string.Join(", ", TestList);
            Assert.That(returnedString == expected);
        }
    }
}