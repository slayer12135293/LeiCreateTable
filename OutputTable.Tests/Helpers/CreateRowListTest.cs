using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OutputTable.Helpers;
using OutputTable.Models;

namespace OutputTable.Tests.Helpers
{
    [TestClass]
    public class CreateRowListTest
    {
        protected SaveToFileViewModel ViewMode = new SaveToFileViewModel() { Column = 3, Row = 5, FileType = "html" };
        private Mock<IConvertStringArrayToString> _convertStringArrayToStringMock;

        [TestMethod]
        public void ShouldReturnRightRowNumbers()
        {
            //arrange 
            _convertStringArrayToStringMock = new Mock<IConvertStringArrayToString>();
            //act
            var createRowList = new CreateRowList(_convertStringArrayToStringMock.Object);
            var result = createRowList.GetRowList(ViewMode);
            //assert
            Assert.AreEqual(result.Count, 5);
        }

        [TestMethod]
        public void ShouldHaveRightRowValuesWhenFileTypeIsHtml()
        {
            //arrange 
            _convertStringArrayToStringMock = new Mock<IConvertStringArrayToString>();
            _convertStringArrayToStringMock.Setup(x => x.ArrayToString(It.IsAny<string[]>())).Returns("James Sara");

            //act
            var createRowList = new CreateRowList(_convertStringArrayToStringMock.Object);
            var result = createRowList.GetRowList(ViewMode);
            //assert
            Assert.AreEqual(result.First(), "James Sara <br>");
        }


        [TestMethod]
        public void ShouldHaveRightRowValuesWhenFileTypeIsText()
        {
            //arrange 
            var viewModeltxt = new SaveToFileViewModel { Column = 3, Row = 5, FileType = "txt" };
            //act
            _convertStringArrayToStringMock = new Mock<IConvertStringArrayToString>();
            var createRowList = new CreateRowList(_convertStringArrayToStringMock.Object);
            var result = createRowList.GetRowList(viewModeltxt);
            //assert
            Assert.AreEqual(result.First(), "0  1  2 ");
        }

    }
}
