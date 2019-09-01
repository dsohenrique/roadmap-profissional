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
        private const string BAD_FILE_NAME = ".txt";
        public TestContext TestContext { get; set; }

        #region Test Initialize e CleanUp
        [TestInitialize]
        public void TestInitialize()
        {
            if (TestContext.TestName == "FileNameDoesExisit")
            {
                if (!string.IsNullOrEmpty(GOOD_FILE_NAME))
                {
                    TestContext.WriteLine($"Creating File {GOOD_FILE_NAME}");
                    File.AppendAllText(GOOD_FILE_NAME, "Hello World");
                }
            }
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (TestContext.TestName == "FileNameDoesExisit")
            {
                if (!string.IsNullOrEmpty(GOOD_FILE_NAME))
                {
                    TestContext.WriteLine($"Deleting File {GOOD_FILE_NAME}");
                    File.Delete(GOOD_FILE_NAME);
                }
            }
        }

        #endregion

        [TestMethod]
        [Description("Verifica se o arquivo exisite")]
        public void FileNameDoesExisit()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            TestContext.WriteLine($"Testing File {GOOD_FILE_NAME}");
            fromCall = fileProcess.fileExisits(GOOD_FILE_NAME);

            Assert.IsTrue(fromCall);
        }
        [TestMethod]
        [Description("Verifica se o arquivo não exisite")]
        public void FileNameDoesNotExisit()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            TestContext.WriteLine($"Testing File {BAD_FILE_NAME}");
            fromCall = fileProcess.fileExisits(BAD_FILE_NAME);

            Assert.IsFalse(fromCall);
        }
        
        
        [TestMethod]
        [Description("Verifica se o arquivo é nulo ou vazio")]
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
