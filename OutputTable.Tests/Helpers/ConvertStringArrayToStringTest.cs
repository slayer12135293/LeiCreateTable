using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutputTable.Helpers;

namespace OutputTable.Tests.Helpers
{
    [TestClass]
    public class ConvertStringArrayToStringTest
    {
        [TestMethod]
        public void ShouldReturnCorrectString()
        {
            //arrange
            var _convertStringArrayToString = new ConvertStringArrayToString();
            var _stringArray = new[] { "sakura", "cammy", "cody" };

            //act
            var result = _convertStringArrayToString.ArrayToString(_stringArray);
            
            //assert
            Assert.AreEqual(result, "sakura cammy cody ");
        }
    }
}
