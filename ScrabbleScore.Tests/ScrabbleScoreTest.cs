
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ScrabbleScore.Models;
using System;

namespace ScrabbleScore.Tests
{
    [TestClass]
    public class ScrabbleScoreTest
    {
        [TestMethod]
        public void CaculateScrabbleScore_ReturnsOne_Int()
        {
            //Arrange
            int expected = 1;
            Scrabble scrabble = new Scrabble("l");
            //Act
            int actual = scrabble.CaculateScrabbleScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CaculateScrabbleScore_Returns33_Int()
        {
            //Arrange
            int expected = 33;
            Scrabble scrabble = new Scrabble("ldbfkjq");
            //Act
            int actual = scrabble.CaculateScrabbleScore();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}