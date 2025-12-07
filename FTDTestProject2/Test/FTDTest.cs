using System;
using FTDTestProject2.CodingProgram;
using NUnit.Framework;

namespace FTDTestProject2
{
    [TestFixture]
    public class FTDTest : UnitTestClassBase
    {
        private ProgrammmingCode programmmingCode;
        
        [OneTimeSetUp]
        public void TestFixtureSetUp()
        {
            // Setup once per fixture
        }

        [SetUp]
        public void SetUp()
        {
            // Before each test
            programmmingCode = new ProgrammmingCode();
        }

        [Test]
        public void Test()
        {
          
            var userChoice = programmmingCode.Game(programmmingCode.paper);
            Console.WriteLine(userChoice);
        }

        [TearDown]
        public void TearDown()
        {
            // Clean up after each test
        }

        [OneTimeTearDown]
        public void TestFixtureTearDown()
        {
            // Clean up once per fixture
        }
    }
}