using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RUSSIANROULETTE_GAME;
namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        GameLogic unitTestObj = new GameLogic();
        [TestMethod]
        public void TestShootaway()
        {
            var nav = unitTestObj.Shootaway(2);
            Assert.AreEqual(expected: 2, nav);
        }

        [TestMethod]
        public void TestShootawayPositive()
        {
            var nav = unitTestObj.Shootaway(0);
            Assert.AreEqual(expected: 2, nav);
        }
    }
}
