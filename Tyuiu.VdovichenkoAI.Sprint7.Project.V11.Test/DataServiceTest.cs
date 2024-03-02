using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.VdovichenkoAI.Sprint7.Project.V11.Lib;

namespace Tyuiu.VdovichenkoAI.Sprint7.Project.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testFilePath = @"C:\Users\Администратор\source\repos\Tyuiu.VdovichenkoAI.Sprint7\Personal.csv";

            int lineCount = 0;


            using (var reader = new StreamReader(testFilePath))
            {

                reader.ReadLine();


                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }


            Assert.AreEqual(48, lineCount);
        }
    }
}
