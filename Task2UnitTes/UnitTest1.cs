using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyFileReader;
using JsonConverter;
using MyJsonModel;
using System.Collections.Generic;
using MyReqest;


namespace Task2UnitTes
{
    [TestClass]
    public class GetJsonStringUnitTest
    {
        [TestMethod]
        public void CorrectFile()
        {
            string jsonString;
            bool expected = true;

            bool result = GetJsonString.ReadFromFile(@"C:\Users\taras\source\repos\Test2\Test2\JSON.txt", out jsonString);

            //assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void IncorrectFile()
        {
            string jsonString;
            bool expected = false;

            bool result = GetJsonString.ReadFromFile(@"asdsad", out jsonString);

            //assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class JsonToModelUnitTest
    {

        [TestMethod]
        public void IncorrectInputString()
        {
            string jsonString = null;
            JsonModel expected = null;

            JsonModel model = JsonToModel.StringToModel(jsonString);

            //assert
            Assert.AreEqual(expected, model);
        }


        [TestMethod]
        public void CorrectInputString()
        {
            string jsonString;
            bool expected = false;

            bool result = GetJsonString.ReadFromFile(@"asdsad", out jsonString);

            //assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void NullReference()
        {
            string jsonString;
            bool expected = false;

            bool result = GetJsonString.ReadFromFile(null, out jsonString);

            //assert
            Assert.AreEqual(expected, result);
        }
    }


    [TestClass]
    public class TestRequestUnitTest
    {
        [TestMethod]
        public void GetUniqueValuesNullReference()
        {
            try
            {
                TestRequest.GetUniqueValues(null, null);
            }
            catch (ArgumentNullException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetOddNumbersNullReference()
        {
            try
            {
                TestRequest.GetOddNumbers(null, null);
            }
            catch (ArgumentNullException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetEvenNbrSumNullReference()
        {
            try
            {
                TestRequest.GetEvenNbrSum(null, null);
            }
            catch (ArgumentNullException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetOddNumbersOverFlow()
        {
            try
            {
                TestRequest.GetOddNumbers(null, null);
            }
            catch (ArgumentNullException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetEvenNbrSumOverFlow()
        {
            try
            {
                TestRequest.GetEvenNbrSum(new int[] { 2, 2147483646 }, new int[] { 1, 4, 8, 9 });
            }
            catch (OverflowException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void GetOddNumbersTrue()
        {
            var expected = new Dictionary<int, int> { { 3, 1 }, { 21, 0 } };
            var result = TestRequest.GetOddNumbers(new int[] { 3, 21 }, new int[] { 2, 4, 8, 9, 3 });

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetEvenNbrSumTrue()
        {
            var expected = 6;

            var result = TestRequest.GetEvenNbrSum(new int[] { 2, 4 }, new int[] { 8, 9, 3 });

            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void GetUniqueValuesTrue()
        {
            var expected = new int[] { 1, 5 };

            var result = TestRequest.GetUniqueValues(new int[] { 1, 9, 3 }, new int[] { 5, 9, 3 });

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetOddNumbersFalse()
        {
            var expected = new Dictionary<int, int> { { 3, 1 } };
            var result = TestRequest.GetOddNumbers(new int[] { 3, 21 }, new int[] { 2, 4, 8, 9, 3 });

            CollectionAssert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void GetEvenNbrSumFalse()
        {
            var expected = 5;

            var result = TestRequest.GetEvenNbrSum(new int[] { 2, 4 }, new int[] { 8, 9, 3 });

            Assert.AreNotEqual(expected, result);
        }


        [TestMethod]
        public void GetUniqueValuesFalse()
        {
            var expected = new int[] { 5 };

            var result = TestRequest.GetUniqueValues(new int[] { 1, 9, 3 }, new int[] { 5, 9, 3 });

            CollectionAssert.AreNotEqual(expected, result);
        }
    }
}