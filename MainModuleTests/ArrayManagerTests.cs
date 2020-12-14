using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainModule.Tests
{
    [TestClass()]
    public class ArrayManagerTests
    {
        //https://www.meziantou.net/mstest-v2-data-tests.htm //Про наборы данных можно подключать объекты или базу данных
        [DataTestMethod]        
        [DataRow(new[] { 3, 2, 1, 6 }, 6)]
        [DataRow(new[] { 1, 200, 33 ,8 ,9 ,60}, 200)]
        [DataRow(new[] { -1, -2, -3 },-1)]
        [DataRow(new[] { -11, -232, -33 }, -11)]
        [DataRow(new[] { 1 }, 1)]
        [DataRow(new[] { 0 }, 0)]
        [DataRow(new[] { 0,0,0,0,0,0 }, 0)]
        public void FindMaxTest01_FindMaxInTestArray(int[] testarr, int expected)
        {            
            //act
            int actual = ArrayManager.FindMax(testarr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [DataTestMethod]
        [DataRow(new[] { 3, 2, 1, 6 }, 3)]
        [DataRow(new[] { 1, 200, 33, 8, 9, 60 }, 51.833)]
        [DataRow(new[] { -1, -2, -3 }, -2)]
        [DataRow(new[] { -11, -232, -33, 23 }, -63.25)]
        [DataRow(new[] { 1 }, 1)]
        [DataRow(new[] { 0 }, 0)]
        [DataRow(new[] { 0, 0, 0, 0, 0, 0 }, 0)]
        public void GetSredneeTest_FindAvgInTestArray(int[] testarr, double expected)
        {
            //act
            double actual = ArrayManager.GetSrednee(testarr);
            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}