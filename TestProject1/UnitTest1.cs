using NUnit.Framework;
using MessageGenerator;
using System;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void CheckforHelloMessageUppercase()
        {
            MessageGen m = new MessageGen();
            m.Message = "Bob";

            var result = m.PrintMessage();

            if(result.Equals("Hello BOB", StringComparison.Ordinal)) // Ordinal is a binary comparison - it checks that case it the same.
            {
                Assert.Pass("Found the expected result");
            } else
            {
                Assert.Fail("Expected output string is not equal to \"Hello BOB\"");
            }
        }

    }
}