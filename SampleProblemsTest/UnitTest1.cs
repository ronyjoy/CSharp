using NUnit.Framework;
using System;
using SampleProblems;
using System.Collections.Generic;

namespace SampleProblemsTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

    

        [Test]
        [TestCase(0, ExpectedResult = "Asha")]
        [TestCase(1, ExpectedResult = "Joy")]
        [TestCase(2, ExpectedResult = "Sonu")]
        [TestCase(2, ExpectedResult = "Thomas")]
        public static string StudentListTest(int pos)
        {
            List<String> students = University.getStudentNamesInAlphabeticalOrder();
            return students[pos];
            
        }




    }
}