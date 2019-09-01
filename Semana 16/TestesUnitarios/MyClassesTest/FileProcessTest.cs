using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClasses;
using System;

namespace MyClassesTest
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExisit()
        {
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            fromCall = fileProcess.fileExisits(@"c:\temp\test.txt");
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
