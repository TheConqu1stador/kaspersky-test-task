using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestHTMLFile()
        {
            //Arrange
            string fileName = "tests\\testHTML.html";
            string expected = "html";

            //Act
            FileContentProvider provider = new FileContentProvider();
            var file = (content: provider.GetContent(fileName), extension: Path.GetExtension(fileName));

            FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
            var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
            fileProcessor.Process(file.content);

            //Assert
            string actual = fileProcessor.ReturnType();
            Assert.AreEqual(expected, actual, "Wrong extension (expected:" + expected);
        }

        [TestMethod]
        public void TestJSONFile()
        {
            //Arrange
            string fileName = "tests\\testJSON.json";
            string expected = "json";

            //Act
            FileContentProvider provider = new FileContentProvider();
            var file = (content: provider.GetContent(fileName), extension: Path.GetExtension(fileName));

            FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
            var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
            fileProcessor.Process(file.content);

            //Assert
            string actual = fileProcessor.ReturnType();
            Assert.AreEqual(expected, actual, "Wrong extension (expected:" + expected);
        }

        [TestMethod]
        public void TestTextFile()
        {
            //Arrange
            string fileName = "tests\\testText.txt";
            string expected = "text";

            //Act
            FileContentProvider provider = new FileContentProvider();
            var file = (content: provider.GetContent(fileName), extension: Path.GetExtension(fileName));

            FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
            var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
            fileProcessor.Process(file.content);

            //Assert
            string actual = fileProcessor.ReturnType();
            Assert.AreEqual(expected, actual, "Wrong extension (expected:" + expected);
        }

        [TestMethod]
        public void TestShouldThrowEmptyExtension()
        {
            //Arrange
            string fileName = "tests\\testEmptyExtension";

            //Act

            try
            {
                FileContentProvider provider = new FileContentProvider();
                var file = (content: provider.GetContent(fileName), extension: Path.GetExtension(fileName));

                FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
                var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
                fileProcessor.Process(file.content);
            }
            catch (System.ArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, FileProcessorFactory.EmptyExtensionMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void TestShouldThrowEmptyFile()
        {
            //Arrange
            string fileName = "tests\\testEmptyFile.txt";

            //Act

            try
            {
                FileContentProvider provider = new FileContentProvider();
                var file = (content: provider.GetContent(fileName), extension: Path.GetExtension(fileName));

                FileProcessorFactory fileProcessorFactory = new FileProcessorFactory();
                var fileProcessor = fileProcessorFactory.CreateFileProcessor(file.content, file.extension);
                fileProcessor.Process(file.content);
            }
            catch (System.ArgumentException e)
            {
                // Assert
                StringAssert.Contains(e.Message, FileProcessorFactory.EmptyFileMessage);
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }
    }
}
