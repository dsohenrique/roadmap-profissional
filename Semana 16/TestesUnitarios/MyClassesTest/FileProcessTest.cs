using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;
using System.IO;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        private const string GOOD_FILE_NAME = @"c:\temp\testesUnitarios.txt";
        public TestContext TestContext { get; set; }

        #region Test Initialize e CleanUp
        [TestInitialize]
        public void TestInitialize()
        {
            if (TestContext.TestName == "FileNameDoesExisit")
            {
                if (string.IsNullOrEmpty(GOOD_FILE_NAME))
                {
                    TestContext.WriteLine($"Creating File {GOOD_FILE_NAME}");
                    File.AppendAllText(GOOD_FILE_NAME, "Hello World");
                }
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (string.IsNullOrEmpty(GOOD_FILE_NAME))
            {
                TestContext.WriteLine($"Deleting File {GOOD_FILE_NAME}");
                File.Delete(GOOD_FILE_NAME);
            }
        }


        [TestMethod]
        public void FileNameDoesExisit()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            TestContext.WriteLine($"Testing File {GOOD_FILE_NAME}");
            fromCall = fileProcess.fileExisits(GOOD_FILE_NAME);

            Assert.IsTrue(fromCall);
        }
        

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameNullOrEmpty_ThrowsArgumentNullException()
        {
            FileProcess fileProcess = new FileProcess();

            fileProcess.fileExisits("");
        }

        [TestMethod]
        public void FileNameNullOrEmpty_ThrowsArgumentNullExceptionUsingTryCatch()
        {
            try
            {
                FileProcess fileProcess = new FileProcess();

                fileProcess.fileExisits("");
            }
            catch (Exception)
            {
                return;
            }
            Assert.Fail("Fail Expected");
        }
    }
}
